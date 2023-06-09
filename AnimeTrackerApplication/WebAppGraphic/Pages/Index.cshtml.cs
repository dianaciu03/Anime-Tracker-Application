using DAL.Repositories;
using Factory;
using log4net;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Azure.Core.HttpHeader;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAnimeManager animeManager;
        private readonly IMangaManager mangaManager;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexModel(IAnimeManager animeManager, IMangaManager mangaManager)
        {
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
            List<Anime> orderedAnime = animes.OrderByDescending(a => a.ReleaseYear).ThenByDescending(a => a.SeasonAnime).Take(12).ToList();
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

        public void LogError(Exception ex)
        {
            log.Error("An error occurred", ex);
        }

        public void OnGet()
        {
            try
            {

            }
            catch(Exception ex)
            {
                log.Error("An error occurred", ex);
            }
        }
    }
}