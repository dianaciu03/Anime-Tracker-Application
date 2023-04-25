using DAL.Repositories;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private IAnimeRepository animeRepository = new AnimeRepository();
        private static IAnimeManager animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());
        private static IMangaManager mangaManager = MangaManagerFactory.CreateMangaManager(MangaRepositoryFactory.CreateMangaRepository());
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

        public List<Anime> NewReleasesAnime
        {
            get { return animeManager.GetAllAnime("ReleaseYear", false).Take(12).ToList(); }
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