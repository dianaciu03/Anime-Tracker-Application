using Factory;
using Logic.Animes;
using Logic.Characters;
using Logic.Enums;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IProfileManager profileManager;
        private readonly IUserManager userManager;
        private readonly IAnimeManager animeManager;
        private readonly IMangaManager mangaManager;
        private readonly ICharacterManager characterManager;
        private readonly IListManager listManager;

        public ProfileModel(IProfileManager profileManager, IUserManager userManager, IAnimeManager animeManager, IMangaManager mangaManager, ICharacterManager characterManager, IListManager listManager)
        {
            this.profileManager = profileManager;
            this.userManager = userManager;
            this.animeManager = animeManager;
            this.mangaManager = mangaManager;
            this.characterManager = characterManager;
            this.listManager = listManager;
        }

        [BindProperty]
        public RegisteredWebUser CurrentUser { get; set; }

        [BindProperty]
        public IFormFile ImageUpload { get; set; }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = userManager.GetWebUserById((int)id);
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
                return Page();
            }
            else
            {
                return RedirectToPage("Login");
            }     
        }

        public List<Genre> GetAllGenres()
        {
            Genre[] genres = (Genre[])Enum.GetValues(typeof(Genre));
            List<Genre> genreList = new List<Genre>(genres);
            return genreList;
        }

        public Anime GetAnimeById(int id)
        {
            return animeManager.GetAnimeById(id);
        }

        public Manga GetMangaById(int id)
        {
            return mangaManager.GetMangaById(id);
        }

        public IActionResult OnPost(string action)
        {
            if (action == "Submit")
            {
                OnGet();
                string[] selectedOptions = Request.Form["options[]"];

                profileManager.DeleteContentFromList(CurrentUser.Profile); //remove previously ticked lists
                int? id = HttpContext.Session.GetInt32("userId");
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
                if (selectedOptions.Count() > 0)
                {
                    foreach (string option in selectedOptions)
                    {
                        Genre genre = (Genre)Enum.Parse(typeof(Genre), option);
                        CurrentUser.Profile.AddGenre(genre);
                    }
                    profileManager.AddPreferedGenres(CurrentUser.Profile);
                }
                return Page();
            }
            return Page();
        }

        public IActionResult OnPostRemoveFromFavourites(string action)
        {
            OnGet();
            int characterId = Convert.ToInt32(action);
            Character character = characterManager.GetCharacterById(characterId);
            character.DecreaseLikes();
            characterManager.UpdateCharacterLikes(character.Id, character.NrLikes);
            CustomList custom = listManager.GetCharacterFavouritesByProfileId(CurrentUser.Profile.Id);
            List<CustomList> lists = new List<CustomList> { custom };
            listManager.DeleteContentFromList(character, lists);
            return RedirectToPage();
        }

        public IActionResult OnPostRemoveFromDisliked(string action)
        {
            OnGet();
            int characterId = Convert.ToInt32(action);
            Character character = characterManager.GetCharacterById(characterId);
            character.DecreaseDislikes();
            characterManager.UpdateCharacterDislikes(character.Id, character.NrDislikes);
            CustomList custom = listManager.GetCharacterDislikedByProfileId(CurrentUser.Profile.Id);
            List<CustomList> lists = new List<CustomList> { custom };
            listManager.DeleteContentFromList(character, lists);
            return RedirectToPage();
        }

        public IActionResult OnPostChangeProfilePicture()
        {

                OnGet();
                string name = ImageUpload.FileName;
                string contentType = ImageUpload.ContentType;
                using(MemoryStream ms = new MemoryStream())
                {
                    ImageUpload.CopyTo(ms);

                    //need to add table and save to database
                }
                return RedirectToPage();

        }
    }
}
