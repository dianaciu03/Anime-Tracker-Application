using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ForYouMangaModel : PageModel
    {
        private IMangaManager mangaManager;
        private IUserManager userManager;

        public ForYouMangaModel(IMangaManager mangaManager, IUserManager userManager)
        {
            this.mangaManager = mangaManager;
            this.userManager = userManager;
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

        public Dictionary<Manga, int> GetRecommendedManga()
        {
            Profile profile = GetProfile();
            return mangaManager.GetRecommendedManga(profile.Id);
        }

        public int GetPercent(int nrMatches)
        {
            return mangaManager.CalculateMatchPercent(nrMatches, GetProfile().GetAllPreferredGenres().Count());
        }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Login");
            }
        }
    }
}
