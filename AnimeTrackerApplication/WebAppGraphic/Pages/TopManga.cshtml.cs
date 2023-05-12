using Factory;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class TopMangaModel : PageModel
    {
        private static IMangaManager mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());

        public List<Manga> TopRatedManga
        {
            get { return mangaManager.GetAllManga("Rating", false); }
        }
        public void OnGet()
        {
        }
    }
}
