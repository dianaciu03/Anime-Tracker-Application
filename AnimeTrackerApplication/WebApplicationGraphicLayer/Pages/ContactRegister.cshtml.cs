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
        [BindProperty]
        public RegisteredWebUser RegistrationFormUser { get; set; } = new RegisteredWebUser();


        [BindProperty]
        [Required(ErrorMessage = "A password is required"),
         MinLength(6, ErrorMessage = "Your password need to be at least 6 characters")]
        public string Password { get; set; } = String.Empty;

        [BindProperty]
        public string PasswordConfirm { get; set; } = String.Empty;

        [BindProperty]
        [Required(ErrorMessage = "A name is required")]
        public string Name { get; set; } = String.Empty;

        [BindProperty]
        [Required(ErrorMessage = "A username is required")]
        public string Username { get; set; } = String.Empty;

        [BindProperty]
        [Required(ErrorMessage = "An email is required"),
         EmailAddress(ErrorMessage = "Your email must be a valid one")]
        public string Email { get; set; } = String.Empty;


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
                RegisteredWebUser webUser = new RegisteredWebUser(RegistrationFormUser.Name, RegistrationFormUser.Email, RegistrationFormUser.Password, DateTime.UtcNow, RegistrationFormUser.Username);
                TempData["WebUser"] = JsonSerializer.Serialize(webUser);
            }
            return RedirectToPage("Index");
        }
    }
}
