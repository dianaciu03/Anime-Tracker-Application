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
        private static UserManager _userManager = new UserManager();
        //private List<User> users = _userManager.GetUsers();

        public void OnGet()
        {
            if (TempData.ContainsKey("WebUser"))
            {
                //RegisteredWebUser webUser = JsonSerializer.Deserialize<RegisteredWebUser>((string)TempData["WebUser"])!;
            }
        }

        public async Task OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //Validate
                //Simulate database
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("id", "email@gmail.com"),
                        new Claim(ClaimTypes.Name, "My name"),
                        new Claim(ClaimTypes.Role, "WebUser")
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
            }
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("Index");
        }
    }
}
