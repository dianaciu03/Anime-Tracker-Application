using Factory;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private static IUserManager userManager = ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());

        [BindProperty]
        public RegisteredWebUser CurrentUser { get; set; }

        public IActionResult OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = (RegisteredWebUser)userManager.GetUserById((int)id);
                return Page();
            }
            else
            {
                return RedirectToPage("Login");
            }
                
        }
    }
}
