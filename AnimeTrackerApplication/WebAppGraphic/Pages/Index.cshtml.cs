using DAL.Repositories;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private static IAnimeRepository animeRepository = new AnimeRepository();
        AnimeManager animeManager;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            animeManager = new AnimeManager(animeRepository);
        }

        public List<Anime> Animes
        {
            get { return animeManager.GetAllAnime(); }
        }

        public IActionResult OnGet()
        {
            //if(HttpContext.Session.Get("Dummy") is null)
            //{
            //    HttpContext.Session.SetString("Dummy", "Some data");
            //}

            return Page();
        }
    }
}