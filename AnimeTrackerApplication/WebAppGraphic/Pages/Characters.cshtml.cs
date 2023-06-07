using Factory;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Text.Json;

namespace WebAppGraphic.Pages
{
    public class CharactersModel : PageModel
    {
        [BindProperty]
        public string CharacterName { get; set; }

        [BindProperty]
        public Profile CurrentProfile { get; set; }

        [BindProperty]
        public Anime Anime { get; set; }

        [BindProperty]
        public Manga Manga { get; set; }

        [BindProperty]
        public List<Character> AlLCharacters { get; set; }

        private readonly ICharacterManager characterManager;
        private readonly IAnimeManager animeManager;
        private readonly IMangaManager mangaManager;
        private readonly IUserManager userManager;
        private readonly IListManager listManager;

        public CharactersModel(ICharacterManager characterManager, IAnimeManager animeManager, IMangaManager mangaManager, IUserManager userManager, IListManager listManager)
        {
            this.characterManager = characterManager;
            this.animeManager = animeManager;
            this.mangaManager = mangaManager;
            this.userManager = userManager;
            this.listManager = listManager;
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

        public List<Character> GetCharacters()
        {
            List<Character> characters = characterManager.GetAllCharacters();
            List<Character> goodCharacters = new List<Character>();
            if (TempData.ContainsKey("CharName"))
            {
                string name = JsonSerializer.Deserialize<string>(TempData["CharName"].ToString())!;
                foreach (Character c in characters)
                {
                    if (c.Name.ToLower().Contains(name.ToLower()))
                    {
                        goodCharacters.Add(c);
                    }
                }
                return goodCharacters;
            }
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
            CurrentProfile = GetProfile();
            AlLCharacters = GetCharacters();
        }

        public IActionResult OnPost()
        {
            if (CharacterName == null)
            {
                CharacterName = "";
            }
            TempData["CharName"] = JsonSerializer.Serialize(CharacterName);
            ModelState.Clear();
            return RedirectToPage();
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

        public IActionResult OnPostAddToDisliked(string action)
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
                character.IncreaseDislikes();
                characterManager.UpdateCharacterDislikes(character.Id, character.NrDislikes);
                CustomList custom = listManager.GetCharacterDislikedByProfileId(CurrentProfile.Id);
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

        public IActionResult OnPostRemoveFromDisliked(string action)
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
                character.DecreaseDislikes();
                characterManager.UpdateCharacterDislikes(character.Id, character.NrDislikes);
                CustomList custom = listManager.GetCharacterDislikedByProfileId(CurrentProfile.Id);
                List<CustomList> lists = new List<CustomList> { custom };
                listManager.DeleteContentFromList(character, lists);
                return RedirectToPage();
            }
        }
    }
}
