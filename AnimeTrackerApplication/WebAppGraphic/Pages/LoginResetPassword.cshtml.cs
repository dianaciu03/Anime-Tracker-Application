using Logic.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;

namespace WebAppGraphic.Pages
{
    public class LoginResetPasswordModel : PageModel
    {
        private readonly IUserManager userManager;

        public LoginResetPasswordModel(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        [BindProperty]
        [Required(ErrorMessage = "An email is required"),
         EmailAddress(ErrorMessage = "Your email address must be valid!")]
        public string UserEmail { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "A password is required"),
         MinLength(5, ErrorMessage = "Your password need to be at least 5 characters!")]
        public string UserPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "A password is required"),
         MinLength(5, ErrorMessage = "Your password need to be at least 5 characters!")]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (UserPassword == ConfirmPassword)
                {
                    RegisteredWebUser? user = null;
                    user = userManager.GetWebUserByEmail(UserEmail);

                    if (user != null)
                    {
                        userManager.UpdateUser(user, UserPassword);
                        User updatedUser = userManager.GetUserById(user.Id);

                        if(userManager.LoginUser(UserPassword, updatedUser.Email) == true)
                        {
                            HttpContext.Session.SetInt32("userId", updatedUser.Id);
                            ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                            new Claim[]
                            {
                        new Claim("UserId", updatedUser.Id.ToString()),
                        //new Claim(ClaimTypes.Name, user.Profile.Username),
                        new Claim(ClaimTypes.Role, updatedUser.GetType().ToString())
                            }, CookieAuthenticationDefaults.AuthenticationScheme);
                            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                            await HttpContext.SignInAsync(claimsPrincipal);
                            return RedirectToPage("Profile");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Credentials did not match!");
                        //await HttpContext.ForbidAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                        return Page();
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credentials did not match!");
                    //await HttpContext.ForbidAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    return Page();
                }
            }
            return Page();
        }
    }
}
