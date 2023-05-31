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

        public AnimeReviewsModel(IAnimeManager animeManager, IUserManager userManager, IReviewManager reviewManager)
        {
            this.animeManager = animeManager;
            this.userManager = userManager;
            this.reviewManager = reviewManager;
        }

        [BindProperty]
        public Review Review { get; set; }

        public List<Review> GetReviews()
        {
            //I need to only get anime reviews
            return reviewManager.GetAllReviews();
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
