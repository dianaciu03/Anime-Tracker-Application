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
        private static IUserManager userManager = UserManagerFactory.CreateUserManager(UserRepositoryFactory.CreateUserRepository());

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                RegisteredWebUser? user = null;
                user = (RegisteredWebUser)userManager.GetUserByEmail(UserEmail);

                if (user != null && user.Password == UserPassword)
                {
                    HttpContext.Session.SetInt32("userId", user.Id);
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Role, user.GetType().ToString())
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToPage("Profile");
                }
                else
                {
                    await HttpContext.ForbidAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    return Page();
                }
            }
            return Page();
        }

        //public IActionResult OnPost()
        //{
        //    RegisteredWebUser? user = null;

        //    if (ModelState.IsValid)
        //    {
        //        user = (RegisteredWebUser)userManager.GetUserByEmail(UserEmail);
        //    }

        //    if(user != null)
        //    {
        //        if(user.Password == UserPassword)
        //            return RedirectToPage("Privacy");
        //        else
        //            return Page();
        //    }
        //    else
        //    {
        //        return Page();
        //    }
        //}
    }
}
