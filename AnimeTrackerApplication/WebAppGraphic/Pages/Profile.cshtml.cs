using Factory;
using Logic.Animes;
using Logic.Characters;
using Logic.Enums;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

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

        [BindProperty]
        public string UsernameInEditMode { get; set; }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = userManager.GetWebUserById((int)id);
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
                if (TempData.ContainsKey("Username"))
                {
                    string newUn = JsonSerializer.Deserialize<string>(TempData["Username"].ToString())!;
                    UsernameInEditMode = newUn;
                }
                return Page();
            }
            else
            {
                return RedirectToPage("Login");
            }     
        }

        public void GetUserAndProfile()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = userManager.GetWebUserById((int)id);
                CurrentUser.Profile = userManager.GetProfileByWebUserId((int)id);
            }
        }

        public byte[] GetBase64Picture(int profileId)
        {
            FileContentResult image = profileManager.GetProfilePicture(profileId);
            return image.FileContents;
        }

        public bool HasProfilePicture(int profileId)
        {
            return profileManager.HasProfilePicture(profileId);
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
                try
                {
                    int profileId = CurrentUser.Profile.Id;
                    if (HasProfilePicture(profileId))
                    {
                        profileManager.UpdateProfilePicture(CurrentUser.Profile.Id, name, ms, contentType);
                    }
                    else
                    {
                        profileManager.AddProfilePicture(CurrentUser.Profile.Id, name, ms, contentType);
                    }   
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return Page();
        }

        public IActionResult OnPostEditUsername(string action)
        {
            TempData["Username"] = JsonSerializer.Serialize(action);
            UsernameInEditMode = action;
            return RedirectToPage();
        }

        public IActionResult OnPostSubmitChanges()
        {
            GetUserAndProfile();
            // Get the values from the form inputs
            profileManager.UpdateUsername(CurrentUser.Profile.Id, UsernameInEditMode);
            return RedirectToPage();
        }
    }
}
