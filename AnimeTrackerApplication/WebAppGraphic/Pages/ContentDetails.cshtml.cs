using DAL.Repositories;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class ContentDetailsModel : PageModel
    {
        private readonly ILogger<ContentDetailsModel> _logger;
        private static Logic.Animes.AnimeRepository animeRepository = new DAL.Repositories.AnimeRepository();
        AnimeManager animeManager;

        public ContentDetailsModel(ILogger<ContentDetailsModel> logger)
        {
            _logger = logger;
            animeManager = new AnimeManager(animeRepository);
        }

        public Anime Anime { get; private set; }

        public void OnGet(int id)
        {
            Anime = animeManager.GetAnimeById(id);
        }
    }
}
