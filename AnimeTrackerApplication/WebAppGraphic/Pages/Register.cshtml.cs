using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using DAL.Repositories;
using Factory;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace WebAppGraphic.Pages
{
    public class RegisterModel : PageModel
    {
        private static IUserManager userManager = ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());

        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; } 

        [BindProperty]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
            ModelState.Clear();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                if (RegistrationFormUser.Password == ConfirmPassword)
                {
                    //add validatio to check that the mail is not repeating
                    (string salt, string hashedPassword) = Security.CreateSaltAndHash(RegistrationFormUser.Password);
                    RegisteredWebUser webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, hashedPassword, DateTime.Now.Date, salt, RegistrationFormUser.Username);
                    //TempData["WebUser"] = JsonSerializer.Serialize(webUser);
                    userManager.AddUser(webUser);

                    //login newly created user
                    RegisteredWebUser user = userManager.GetWebUserByEmail(webUser.Email);
                    HttpContext.Session.SetInt32("userId", user.Id);
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("userId", "user.Id"),
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, user.GetType().ToString())
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToPage("Profile");
                }
                else
                    return Page();
            }
            return Page();
        }
    }
}
