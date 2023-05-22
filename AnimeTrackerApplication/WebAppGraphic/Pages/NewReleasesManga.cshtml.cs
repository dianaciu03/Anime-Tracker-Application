using Factory;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class NewReleasesMangaModel : PageModel
    {
        private static IMangaManager mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());

        public List<Manga> NewReleasesManga()
        {
            List<Manga> mangas = mangaManager.GetAllManga("ReleaseYear", false);
            return mangas;
        }
    }
}
