using Factory;
using Logic.Enums;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IProfileManager profileManager;
        private readonly IUserManager userManager;

        public ProfileModel(IProfileManager profileManager, IUserManager userManager)
        {
            this.profileManager = profileManager;
            this.userManager = userManager;
        }

        [BindProperty]
        public RegisteredWebUser CurrentUser { get; set; }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = userManager.GetWebUserById((int)id);
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
                return Page();
            }
            else
            {
                return RedirectToPage("Login");
            }     
        }

        public List<Genre> GetAllGenres()
        {
            Genre[] genres = (Genre[])Enum.GetValues(typeof(Genre));
            List<Genre> genreList = new List<Genre>(genres);
            return genreList;
        }

        public IActionResult OnPost(string action)
        {
            if (action == "Submit")
            {
                OnGet();
                string[] selectedOptions = Request.Form["options[]"];

                profileManager.DeleteContentFromList(CurrentUser.Profile); //remove previously ticked lists
                int? id = HttpContext.Session.GetInt32("userId");
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {
                        Genre genre = (Genre)Enum.Parse(typeof(Genre), option);
                        CurrentUser.Profile.AddGenre(genre);
                    }
                    profileManager.AddPreferedGenres(CurrentUser.Profile);
                }
                return Page();
            }
            return Page();
        }
    }
}
