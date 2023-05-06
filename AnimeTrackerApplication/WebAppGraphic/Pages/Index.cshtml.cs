using DAL.Repositories;
using Factory;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Azure.Core.HttpHeader;

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private static IAnimeManager animeManager = ManagerFactory.CreateAnimeManager(RepositoryFactory.CreateAnimeRepository());
        private static IMangaManager mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());
        //private static ICharacterManager characterManager = CharacterManagerFactory.CreateCharacterManager(CharacterRepositoryFactory.CreateCharacterRepository());
        //userManager = UserManagerFactory.CreateUserManager(UserRepositoryFactory.CreateUserRepository());

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Anime> TopRatedAnime
        {
            get { return animeManager.GetAllAnime("Rating", false).Take(12).ToList(); }
        }

        public List<Anime> NewReleasesAnime()
        {
            List<Anime> animes = animeManager.GetAllAnime("ReleaseYear", false);
            List<Anime> orderedAnime = animes.OrderByDescending(a => a.SeasonAnime).Take(12).ToList();
            return orderedAnime;
        }

        //public IActionResult OnGet()
        //{
        //    //if(HttpContext.Session.Get("Dummy") is null)
        //    //{
        //    //    HttpContext.Session.SetString("Dummy", "Some data");
        //    //}

        //    //return Page();
        //}

        public void OnGet()
        {

        }
    }
}