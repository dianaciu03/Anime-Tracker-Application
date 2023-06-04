using Logic.Animes;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebAppGraphic.Pages
{
    public class AnimeReviewsModel : PageModel
    {
        private IAnimeManager animeManager;
        private IUserManager userManager;
        private IReviewManager reviewManager;
        private IProfileManager profileManager;

        public AnimeReviewsModel(IAnimeManager animeManager, IUserManager userManager, IReviewManager reviewManager, IProfileManager profileManager)
        {
            this.animeManager = animeManager;
            this.userManager = userManager;
            this.reviewManager = reviewManager;
            this.profileManager = profileManager;
        }

        [BindProperty]
        public Anime Anime { get; set; }

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
            return reviewManager.GetAllReviews("Anime");
        }

        public void GetProfileById(int id)
        {
            Profile = profileManager.GetProfileById(id);
        }

        public string CalculateTime(DateTime date)
        {
            return reviewManager.CalculateTimeAgo(date);
        }

        public void GetAnimeById(int id)
        {
            Anime = animeManager.GetAnimeById(id);
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
