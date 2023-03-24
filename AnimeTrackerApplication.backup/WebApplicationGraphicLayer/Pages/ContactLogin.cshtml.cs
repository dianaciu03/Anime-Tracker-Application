using IdividualLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebApplicationGraphicLayer.Pages
{
    public class ContactLoginModel : PageModel
    {
        private static UserManager _userManager = new UserManager();
        private List<User> users = _userManager.GetUsers();

        public void OnGet()
        {
            if (TempData.ContainsKey("WebUser"))
            {
                //RegisteredWebUser webUser = JsonSerializer.Deserialize<RegisteredWebUser>((string)TempData["WebUser"])!;
            }
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("Index");
        }
    }
}
