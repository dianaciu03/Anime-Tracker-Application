using Logic.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using DAL.Repositories;
using Factory;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Logic.Profiles;

namespace WebAppGraphic.Pages
{
    public class RegisterModel : PageModel
    {
        private static IUserManager userManager= ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());

        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; }

        [BindProperty]
        public Profile RegistrationProfile { get; set; }

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
                    bool userExists = false;
                    foreach(User existUser in userManager.GetAllWebUsers())
                    {
                        if (existUser.Email == RegistrationFormUser.Email)
                        {
                            userExists = true;
                            ModelState.AddModelError(string.Empty, "This email address is unavailable.");
                        }
                    }

                    if(userExists == false)
                    {
                        (string salt, string hashedPassword) = Security.CreateSaltAndHash(RegistrationFormUser.Password);
                        Profile webProfile = new Profile(RegistrationProfile.Username);
                        RegisteredWebUser webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, hashedPassword, DateTime.Now.Date, salt, webProfile);
                        //TempData["WebUser"] = JsonSerializer.Serialize(webUser);
                        userManager.AddUser(webUser);

                        //login newly created user
                        RegisteredWebUser user = userManager.GetWebUserByEmail(webUser.Email);
                        HttpContext.Session.SetInt32("userId", user.Id);
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                        new Claim[]
                        {
                        new Claim("userId", "user.Id"),
                        //new Claim(ClaimTypes.Name, user.Profile.Username),
                        new Claim(ClaimTypes.Role, user.GetType().ToString())
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToPage("Profile");
                    }
                }
                else
                    return Page();
            }
            return Page();
        }
    }
}
