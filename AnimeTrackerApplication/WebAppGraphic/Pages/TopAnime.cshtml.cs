using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class TopAnimeModel : PageModel
    {
        private static IAnimeManager animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());

        public List<Anime> TopRatedAnime
        {
            get { return animeManager.GetAllAnime("Rating", false); }
        }

        public void OnGet()
        {
        }

        
    }
}
