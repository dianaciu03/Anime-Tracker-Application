using Logic.Animes;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace WebAppGraphic.Pages
{
    public class ContentDetailsModel : PageModel
    {
        private IAnimeManager animeManager;
        private IUserManager userManager;
        private IListManager listManager;

        public ContentDetailsModel(IAnimeManager animeManager, IUserManager userManager, IListManager customListManager)
        {
            this.animeManager = animeManager;
            this.userManager = userManager;
            this.listManager = customListManager;
        }

        [BindProperty]
        public Anime Anime { get; set; }

        [BindProperty]
        public Review Review { get; set; }

        public List<CustomList> GetAllAnimeLists()
        {
            return listManager.GetAnimeListByProfileId(GetProfile().Id);
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
                listManager.DeleteContentFromList(Anime, listManager.GetAnimeListByProfileId(GetProfile().Id)); //remove previously ticked lists
                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {
                        CustomList temp = GetProfile().GetList(option, "Anime");
                        listManager.AddContentToCustomList(Anime, temp);
                    }
                }
                return Page();
            }
            else if (action == "Review")
            {
                OnGet(Anime.Id);
                listManager.DeleteContentFromList(Anime, listManager.GetAnimeListByProfileId(GetProfile().Id)); //remove previously ticked lists
                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {
                        CustomList temp = GetProfile().GetList(option, "Anime");
                        listManager.AddContentToCustomList(Anime, temp);
                    }
                }
                return Page();
            }

            return Page();
        }
    }
}
