using Logic.Animes;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ForYouAnimeModel : PageModel
    {
        private IAnimeManager animeManager;
        private IUserManager userManager;

        public ForYouAnimeModel(IAnimeManager animeManager, IUserManager userManager)
        {
            this.animeManager = animeManager;
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

        public Dictionary<Anime, int> GetRecommendedAnime()
        {
            Profile profile = GetProfile();
            return animeManager.GetRecommendedAnime(profile.Id);
        }

        public void OnGet()
        {
        }
    }
}
