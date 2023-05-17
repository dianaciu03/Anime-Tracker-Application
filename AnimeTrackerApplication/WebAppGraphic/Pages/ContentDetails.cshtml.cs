using Logic.Animes;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace WebAppGraphic.Pages
{
    public class ContentDetailsModel : PageModel
    {
        private readonly ILogger<ContentDetailsModel> _logger;
        private IAnimeManager animeManager;
        private IUserManager userManager;

        public ContentDetailsModel(ILogger<ContentDetailsModel> logger, IAnimeManager animeManager, IUserManager userManager)
        {
            _logger = logger;
            this.animeManager = animeManager;
            this.userManager = userManager;
        }

        [BindProperty]
        public Anime Anime { get; set; }

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

        public void OnGet(int id)
        {
                Anime = animeManager.GetAnimeById(id);
        }

        public int? IsUserLoggedIn()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id!= null) {
                return id;
            }
            else {
                return null;
            }
        }
        public IActionResult OnPost(string action)
        {
            if(action == "Login")
            {
                return RedirectToPage("Login");
            }
            else if(action == "Submit")
            {
                OnGet(Anime.Id);
                string[] selectedOptions = Request.Form["options[]"];

                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {

                    }
                }

                return Page();
            }
            return Page();
        }


    }
}
