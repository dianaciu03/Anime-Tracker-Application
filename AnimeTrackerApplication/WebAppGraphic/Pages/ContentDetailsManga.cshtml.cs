using Logic.Animes;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class ContentDetailsMangaModel : PageModel
    {
        private readonly IMangaManager mangaManager;
        private readonly IUserManager userManager;
        private readonly IListManager listManager;
        private readonly IReviewManager reviewManager;

        public ContentDetailsMangaModel(IMangaManager mangaManager, IUserManager userManager, IListManager customListManager, IReviewManager reviewManager)
        {
            this.mangaManager = mangaManager;
            this.userManager = userManager;
            this.listManager = customListManager;
            this.reviewManager = reviewManager;
        }
        [BindProperty]
        public string ReviewDescription { get; set; }

        [BindProperty]
        public int ReviewRating { get; set; }

        [BindProperty]
        public Manga Manga { get; set; }

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

        public CustomList CList { get; set; }

        public List<CustomList> GetAllMangaLists()
        {
            return listManager.GetMangaListByProfileId(GetProfile().Id);
        }

        public void OnGet(int id)
        {
            Manga = mangaManager.GetMangaById(id);
        }

        public int? IsUserLoggedIn()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                return id;
            }
            else
            {
                return null;
            }
        }
        public IActionResult OnPost(string action)
        {
            if (action == "Login")
            {
                return RedirectToPage("Login");
            }
            else if (action == "Submit")
            {
                OnGet(Manga.Id);
                string[] selectedOptions = Request.Form["options[]"];
                listManager.DeleteContentFromList(Manga, listManager.GetMangaListByProfileId(GetProfile().Id)); //remove previously ticked lists
                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {
                        CustomList temp = GetProfile().GetList(option, "Manga");
                        listManager.AddContentToCustomList(Manga, temp);
                    }
                }
                return Page();
            }
            else if (action == "Review")
            {
                if (GetProfile() == null)
                {
                    OnGet(Manga.Id);
                    ModelState.AddModelError(string.Empty, "You need to be logged in to access this feature!");
                }
                else
                {
                    OnGet(Manga.Id);
                    reviewManager.AddReview(GetProfile().Id, ReviewRating, ReviewDescription, Manga.Id, "Anime", DateTime.Now);
                    ReviewDescription = string.Empty;
                    ReviewRating = 0;
                    ModelState.Clear();
                }
            }
            return Page();
        }
    }
}
