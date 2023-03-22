using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;
using System;
using IdividualLogicLayer;
using System.Text.Json;

namespace WebApplicationGraphicLayer.Pages
{
    public class ContactRegisterModel : PageModel
    {
        private static UserManager _userManager = new UserManager();

        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; } = new RegisteredWebUser();




        public void OnGet()
        {
            ModelState.Clear();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(RegistrationFormUser.Password == RegistrationFormUser.PasswordConfirm)
            {
                User webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, RegistrationFormUser.Password, DateTime.UtcNow, RegistrationFormUser.Username);
                TempData["WebUser"] = JsonSerializer.Serialize(webUser);
                _userManager.AddUser(webUser);
            }
            return RedirectToPage("Index");
        }
    }
}
