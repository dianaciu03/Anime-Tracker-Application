using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebAppGraphic.Pages
{
    public class MangaReviewsModel : PageModel
    {
        private IMangaManager mangaManager;
        private IUserManager userManager;
        private IReviewManager reviewManager;
        private IProfileManager profileManager;

        public MangaReviewsModel(IMangaManager mangaManager, IUserManager userManager, IReviewManager reviewManager, IProfileManager profileManager)
        {
            this.mangaManager = mangaManager;
            this.userManager = userManager;
            this.reviewManager = reviewManager;
            this.profileManager = profileManager;
        }

        [BindProperty]
        public Manga Manga { get; set; }

        [BindProperty]
        public Profile Profile { get; set; }

        [BindProperty]
        public Profile CurrentProfile { get; set; }

        [BindProperty]
        public int ReviewRating { get; set; }

        [BindProperty]
        public string ReviewDescription { get; set; }

        [BindProperty]
        public int IdReviewInEditMode { get; set; }

        public List<Review> GetReviews()
        {
            List<Review> reviews = reviewManager.GetAllReviews("Manga");
            List<Review> orderedReviews = reviews.OrderByDescending(r => r.Date).ToList();
            return orderedReviews;
        }

        public void GetProfileById(int id)
        {
            Profile = profileManager.GetProfileById(id);
        }

        public string CalculateTime(DateTime date)
        {
            return reviewManager.CalculateTimeAgo(date, DateTime.Now);
        }

        public void GetMangaById(int id)
        {
            Manga = mangaManager.GetMangaById(id);
        }

        public Profile GetProfile()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                Profile profile = userManager.GetProfileByWebUserId((int)id);
                return profile;
            }
            else
            {
                return null;
            }
        }

        public IActionResult OnGet()
        {
            CurrentProfile = GetProfile();
            if (TempData.ContainsKey("ReviewId"))
            {
                int newId = JsonSerializer.Deserialize<int>(Convert.ToInt32(TempData["ReviewId"]))!;
                IdReviewInEditMode = newId;
                Review review = reviewManager.GetReviewById(newId);
                InitializeReviewData(review);
            }
            return Page();
        }

        private void InitializeReviewData(Review review)
        {
            ReviewRating = review.Rating;
            ReviewDescription = review.Description;
        }

        public IActionResult OnPostEditReview(string action)
        {
            int id = Convert.ToInt32(action);
            TempData["ReviewId"] = JsonSerializer.Serialize(id);
            return RedirectToPage();
        }

        public IActionResult OnPostDeleteReview(string action)
        {
            int id = Convert.ToInt32(action);
            reviewManager.DeleteReview(id);
            return RedirectToPage();
        }

        public IActionResult OnPostSubmitChanges(string action)
        {
            int id = Convert.ToInt32(action);
            // Get the values from the form inputs
            reviewManager.UpdateReview(ReviewRating, ReviewDescription, id);
            return RedirectToPage();
        }
    }
}
