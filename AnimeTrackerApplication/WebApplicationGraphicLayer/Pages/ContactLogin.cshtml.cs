using IdividualLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebApplicationGraphicLayer.Pages
{
    public class ContactLoginModel : PageModel
    {
        public void OnGet()
        {
            if (TempData.ContainsKey("Admin"))
            {
                RegisteredWebUser webUser = JsonSerializer.Deserialize<RegisteredWebUser>((string)TempData["WebUser"])!;
                
            }
        }
    }
}
