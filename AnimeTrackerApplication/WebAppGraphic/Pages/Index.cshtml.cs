using DAL.Repositories;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private IAnimeRepository animeRepository = new AnimeRepository();
        private static IAnimeManager animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Anime> Animes
        {
            get { return animeManager.GetAllAnime("Rating", false, 10000); }
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