using Logic.Animes;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public Review Review { get; set; }

        [BindProperty]
        public Anime Anime { get; set; }

        [BindProperty]
        public Profile Profile { get; set; }

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
    }
}
