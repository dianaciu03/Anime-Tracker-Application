using Logic.Animes;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class TopMangaModel : PageModel
    {

        private IMangaManager mangaManager;

        public TopMangaModel(IMangaManager mangaManager)
        {
            this.mangaManager = mangaManager;
        }

        [BindProperty]
        public string MangaName { get; set; }

        [BindProperty]
        public List<Manga> AlLManga { get; set; }

        public List<Manga> TopRatedManga()
        {
            return mangaManager.GetAllManga("Rating", false);
        }

        public void OnGet()
        {
            AlLManga = TopRatedManga();
        }

        public IActionResult OnPost()
        {
            if (MangaName == null)
            {
                MangaName = "";
            }
            AlLManga.Clear();
            foreach (Manga manga in TopRatedManga())
            {
                if (manga.Name.ToLower().Contains(MangaName.ToLower()))
                {
                    AlLManga.Add(manga);
                }
            }
            MangaName = string.Empty;
            ModelState.Clear();
            return Page();
        }
    }
}
