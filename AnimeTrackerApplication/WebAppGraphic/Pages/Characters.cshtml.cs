using Factory;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class CharactersModel : PageModel
    {
        [BindProperty]
        public string CharacterName { get; set; }

        [BindProperty]
        public Anime Anime { get; set; }

        [BindProperty]
        public Manga Manga { get; set; }

        [BindProperty]
        public List<Character> AlLCharacters { get; set; }

        private readonly ICharacterManager characterManager;
        private readonly IAnimeManager animeManager;
        private readonly IMangaManager mangaManager;

        public CharactersModel(ICharacterManager characterManager, IAnimeManager animeManager, IMangaManager mangaManager)
        {
            this.characterManager = characterManager;
            this.animeManager = animeManager;
            this.mangaManager = mangaManager;
        }

        public List<Character> GetCharacters()
        {
            List<Character> characters = characterManager.GetAllCharacters();
            return characters;
        }

        public Anime GetAnimeById(int id)
        {
            return animeManager.GetAnimeById(id);
        }

        public Manga GetMangaById(int id)
        {
            return mangaManager.GetMangaById(id);
        }

        public void OnGet()
        {
            AlLCharacters = GetCharacters();
        }

        public IActionResult OnPost()
        {
            if (CharacterName == null)
            {
                CharacterName = "";
            }
            AlLCharacters.Clear();
            foreach (Character character in GetCharacters())
            {
                if (character.Name.ToLower().Contains(CharacterName.ToLower()))
                {
                    AlLCharacters.Add(character);
                }
            }
            CharacterName = string.Empty;
            ModelState.Clear();
            return Page();
        }
    }
}
