using Factory;
using Logic.Animes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class TopAnimeModel : PageModel
    {
        [BindProperty]
        public string AnimeName { get; set; }

        [BindProperty]
        public List<Anime> AlLAnime { get; set; }

        private static IAnimeManager animeManager = ManagerFactory.CreateAnimeManager(RepositoryFactory.CreateAnimeRepository());

        public List<Anime> TopRatedAnime()
        {
            return animeManager.GetAllAnime("Rating", false);
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
