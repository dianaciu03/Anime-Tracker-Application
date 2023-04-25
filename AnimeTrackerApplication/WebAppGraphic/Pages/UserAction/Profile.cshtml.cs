using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private static IUserManager userManager = UserManagerFactory.CreateUserManager(UserRepositoryFactory.CreateUserRepository());

        [BindProperty]
        public RegisteredWebUser CurrentUser { get; set; }

        public void OnGet()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                CurrentUser = (RegisteredWebUser)userManager.GetUserById((int)id);
            }
        }
    }
}
