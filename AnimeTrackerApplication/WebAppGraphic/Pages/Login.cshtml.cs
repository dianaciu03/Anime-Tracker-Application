using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Logic.Users;
using System.Text.Json;
using DAL.Repositories;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;

namespace WebAppGraphic.Pages
{
    public class LoginModel : PageModel
    {
        private static UserManager userManager = UserManagerFactory.CreateUserManager(UserRepositoryFactory.CreateUserRepository());

        [BindProperty]
        public string UserEmail { get; set; }

        [BindProperty]
        public string UserPassword { get; set; }

        public void OnGet()
        {
            //if (TempData.ContainsKey("WebUser"))
            //{
            //    RegisteredWebUser webUser = JsonSerializer.Deserialize<RegisteredWebUser>((string)TempData["WebUser"])!;
            //}
        }

        //public async Task OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //Validate
        //        //Simulate database
        //        //ClaimsIdentity claimsIdentity = new ClaimsIdentity(
        //        //    new Claim[]
        //        //    {
        //        //        new Claim("id", "email@gmail.com"),
        //        //        new Claim(ClaimTypes.Name, "My name"),
        //        //        new Claim(ClaimTypes.Role, "WebUser")
        //        //    }, CookieAuthenticationDefaults.AuthenticationScheme);
        //        //ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        //        //await HttpContext.SignInAsync(claimsPrincipal);
        //    }


        //}

        public IActionResult OnPost()
        {
            RegisteredWebUser? user = null;

            if (ModelState.IsValid)
            {
                user = (RegisteredWebUser)userManager.GetUserByEmail(UserEmail);
            }

            if(user != null)
            {
                if(user.Password == UserPassword)
                    return RedirectToPage("Privacy");
                else
                    return Page();
            }
            else
            {
                return Page();
            }
        }
    }
}
