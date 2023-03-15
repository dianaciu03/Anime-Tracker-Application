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
                Admin admin = JsonSerializer.Deserialize<Admin>((string)TempData["Admin"])!;
                
            }
        }
    }
}
