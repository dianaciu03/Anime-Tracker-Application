using Factory;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class NewReleasesAnimeModel : PageModel
    {
        [BindProperty]
        public string AnimeName { get; set; }

        [BindProperty]
        public List<Anime> AlLAnime { get; set; }

        private IAnimeManager animeManager;

        public NewReleasesAnimeModel(IAnimeManager animeManager)
        {
            this.animeManager = animeManager;
        }

        public List<Anime> TopRatedAnime()
        {
            List<Anime> animes = animeManager.GetAllAnime("ReleaseYear", false);
            List<Anime> orderedAnime = animes.OrderByDescending(a => a.ReleaseYear).ThenByDescending(a => a.SeasonAnime).ToList();
            return orderedAnime;
        }

        public void OnGet()
        {
            AlLAnime = TopRatedAnime();
        }

        public IActionResult OnPost()
        {
            if (AnimeName == null)
            {
                AnimeName = "";
            }
            AlLAnime.Clear();
            foreach (Anime anime in TopRatedAnime())
            {
                if (anime.Name.ToLower().Contains(AnimeName.ToLower()))
                {
                    AlLAnime.Add(anime);
                }
            }
            AnimeName = string.Empty;
            ModelState.Clear();
            return Page();
        }
    }
}
