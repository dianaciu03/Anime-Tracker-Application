using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Logic.Users;
using DAL.Repositories;

namespace WebAppGraphic.Pages
{
    public class RegisterModel : PageModel
    {
        private static IUserRepository _userDataHandler= new UserRepository();
        private static UserManager userManager = new UserManager(_userDataHandler);

        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; } 

        [BindProperty]
        public string ConfirmPassword { get; set; }

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
                User webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, RegistrationFormUser.Password, DateTime.Now.Date, RegistrationFormUser.Username);
                //TempData["WebUser"] = JsonSerializer.Serialize(webUser);
                userManager.AddUser(webUser);
                return RedirectToPage("Login");
            }
            else
            return Page();
        }
    }
}
