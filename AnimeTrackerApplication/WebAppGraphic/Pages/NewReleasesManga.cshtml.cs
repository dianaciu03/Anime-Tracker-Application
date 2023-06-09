using Factory;
using Logic.Mangas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class NewReleasesMangaModel : PageModel
    {
        private IMangaManager mangaManager;

        public NewReleasesMangaModel(IMangaManager mangaManager)
        {
            this.mangaManager = mangaManager;
        }

        [BindProperty]
        public string MangaName { get; set; }

        [BindProperty]
        public List<Manga> AlLManga { get; set; }

        public List<Manga> NewReleasesManga()
        {
            List<Manga> mangas = mangaManager.GetAllManga("ReleaseYear", false);
            return mangas;
        }

        public void OnGet()
        {
            AlLManga = NewReleasesManga();
        }

        public IActionResult OnPost()
        {
            if (MangaName == null)
            {
                MangaName = "";
            }
            AlLManga.Clear();
            foreach (Manga manga in NewReleasesManga())
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
