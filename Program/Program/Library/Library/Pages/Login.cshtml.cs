using Library_Class;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Library.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string pass { get; set; }

        
        public string msg;

        public void OnGet()
        {
            if(User.Identity != null)
            {
                HttpContext.SignOutAsync();
            }
        }
             

        public IActionResult OnPost()
        {
            bool loginsuccesfull = AccountManagement.Login(email,pass,out string role,out string id);
            if (ModelState.IsValid & loginsuccesfull)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Email,email));
                claims.Add(new Claim("id", id));
                claims.Add(new Claim(ClaimTypes.Role, role));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }
    }
}
