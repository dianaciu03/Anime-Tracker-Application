using DAL.Repositories;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class ContentDetailsModel : PageModel
    {
        private readonly ILogger<ContentDetailsModel> _logger;
        private static IAnimeRepository animeRepository = new AnimeRepository();
        AnimeManager animeManager;

        public ContentDetailsModel(ILogger<ContentDetailsModel> logger)
        {
            _logger = logger;
            animeManager = new AnimeManager(animeRepository);
        }

        public Anime Anime { get; private set; }

        public void OnGet(string id)
        {
            //Anime = animeManager.GetById(id);
        }
    }
}
