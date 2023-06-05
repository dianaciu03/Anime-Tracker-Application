using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebAppGraphic.Pages
{
    public class CharacterTopsModel : PageModel
    {
        [BindProperty]
        public Profile CurrentProfile { get; set; }

        [BindProperty]
        public Anime Anime { get; set; }

        [BindProperty]
        public Manga Manga { get; set; }

        [BindProperty]
        public List<Character> AlLFavouriteCharacters { get; set; }

        [BindProperty]
        public List<Character> AlLHatedCharacters { get; set; }

        private readonly ICharacterManager characterManager;
        private readonly IAnimeManager animeManager;
        private readonly IMangaManager mangaManager;
        private readonly IUserManager userManager;
        private readonly IListManager listManager;

        public CharacterTopsModel(ICharacterManager characterManager, IAnimeManager animeManager, IMangaManager mangaManager, IUserManager userManager, IListManager listManager)
        {
            this.characterManager = characterManager;
            this.animeManager = animeManager;
            this.mangaManager = mangaManager;
            this.userManager = userManager;
            this.listManager = listManager;
        }

        public Anime GetAnimeById(int id)
        {
            return animeManager.GetAnimeById(id);
        }

        public Manga GetMangaById(int id)
        {
            return mangaManager.GetMangaById(id);
        }

        public Profile GetProfile()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                Profile profile = userManager.GetProfileByWebUserId((int)id);
                return profile;
            }
            else
            {
                return null;
            }
        }

        public List<Character> GetFavouriteCharacters()
        {
            List<Character> characters = characterManager.GetAllCharacters();
            List<Character> orderedCharacters = characters.OrderByDescending(c => c.NrLikes).ToList();
            return orderedCharacters;
        }
        public void OnGet()
        {
            CurrentProfile = GetProfile();
            AlLFavouriteCharacters = GetFavouriteCharacters().Take(12).ToList();
        }

        public IActionResult OnPostAddToFavourites(string action)
        {
            CurrentProfile = GetProfile();
            if (CurrentProfile == null)
            {
                return RedirectToPage("Login");
            }
            else
            {
                int characterId = Convert.ToInt32(action);
                Character character = characterManager.GetCharacterById(characterId);
                character.IncreaseLikes();
                characterManager.UpdateCharacterLikes(character.Id, character.NrLikes);
                CustomList custom = listManager.GetCharacterFavouritesByProfileId(CurrentProfile.Id);
                listManager.AddContentToCustomList(character, custom);
                return RedirectToPage();
            }
        }

        public IActionResult OnPostRemoveFromFavourites(string action)
        {
            CurrentProfile = GetProfile();
            if (CurrentProfile == null)
            {
                return RedirectToPage("Login");
            }
            else
            {
                int characterId = Convert.ToInt32(action);
                Character character = characterManager.GetCharacterById(characterId);
                character.DecreaseLikes();
                characterManager.UpdateCharacterLikes(character.Id, character.NrLikes);
                CustomList custom = listManager.GetCharacterFavouritesByProfileId(CurrentProfile.Id);
                List<CustomList> lists = new List<CustomList> { custom };
                listManager.DeleteContentFromList(character, lists);
                return RedirectToPage();
            }
        }
    }
}
