using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Logic.Users;
using System.Text.Json;

namespace WebAppGraphic.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserManager userManager;

        public LoginModel(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        [BindProperty]
        public string UserEmail { get; set; }

        [BindProperty]
        public string UserPassword { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                RegisteredWebUser? user = null;
                user = userManager.GetWebUserByEmail(UserEmail);

                if (user != null && userManager.LoginUser(UserPassword, UserEmail) == true)
                {
                    HttpContext.Session.SetInt32("userId", user.Id);
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("UserId", user.Id.ToString()),
                        //new Claim(ClaimTypes.Name, user.Profile.Username),
                        new Claim(ClaimTypes.Role, user.GetType().ToString())
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToPage("Profile");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credentials did not match!");
                    //await HttpContext.ForbidAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    return Page();
                }
            }
            return Page();
        }
    }
}
