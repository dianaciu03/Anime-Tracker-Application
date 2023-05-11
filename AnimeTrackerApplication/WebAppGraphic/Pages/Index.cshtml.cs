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
        private IAnimeManager animeManager;
        private IMangaManager mangaManager;
        //private static ICharacterManager characterManager = CharacterManagerFactory.CreateCharacterManager(CharacterRepositoryFactory.CreateCharacterRepository());
        //userManager = UserManagerFactory.CreateUserManager(UserRepositoryFactory.CreateUserRepository());

        public IndexModel(ILogger<IndexModel> logger, IAnimeManager animeManager, IMangaManager mangaManager)
        {
            _logger = logger;
            this.animeManager = animeManager;
            this.mangaManager = mangaManager;
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

        public List<Manga> TopRatedManga
        {
            get { return mangaManager.GetAllManga("Rating", false).Take(12).ToList(); }
        }

        public List<Manga> NewReleasesManga()
        {
            List<Manga> mangas = mangaManager.GetAllManga("ReleaseYear", false).Take(12).ToList(); 
            return mangas;
        }

        public void OnGet()
        {

        }
    }
}