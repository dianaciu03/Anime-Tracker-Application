using Factory;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class NewReleasesAnimeModel : PageModel
    {
        private static IAnimeManager animeManager = ManagerFactory.CreateAnimeManager(RepositoryFactory.CreateAnimeRepository());

        public List<Anime> TopRatedAnime()
        {
            List<Anime> animes = animeManager.GetAllAnime("ReleaseYear", false);
            List<Anime> orderedAnime = animes.OrderByDescending(a => a.ReleaseYear).ThenByDescending(a => a.SeasonAnime).ToList();
            return orderedAnime;
        }

        public void OnGet()
        {
        }
    }
}
