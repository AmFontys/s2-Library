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
        public string fname { get; set; }
        [BindProperty]
        public string lname { get; set; }
        [BindProperty]
        public string pass { get; set; }

        
        public string msg;

        public void OnGet()
        {
        }
             

        public IActionResult OnPost()
        {
            bool loginsuccesfull = Account.Login(fname,lname,pass,out string role);
            if (ModelState.IsValid & loginsuccesfull)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, fname+" "+lname));
                claims.Add(new Claim("id", "1"));
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
