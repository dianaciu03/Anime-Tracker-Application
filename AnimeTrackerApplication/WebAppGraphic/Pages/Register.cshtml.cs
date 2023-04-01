using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Logic.Users;

namespace WebAppGraphic.Pages
{
    public class RegisterModel : PageModel
    {
        private static UserManager _userManager = new UserManager();

        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; } = new RegisteredWebUser();

        [BindProperty]
        public string ConfirmPassword { get; set; };

        public void OnGet()
        {
            ModelState.Clear();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (RegistrationFormUser.Password == ConfirmPassword)
            {
                User webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, RegistrationFormUser.Password, DateTime.UtcNow, RegistrationFormUser.Username);
                //TempData["WebUser"] = JsonSerializer.Serialize(webUser);
                _userManager.AddUser(webUser);
            }
            return RedirectToPage("Index");
        }
    }
}
