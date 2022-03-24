using Library.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            bool loginsuccesfull = Account.Login(fname,lname,pass);
            if (ModelState.IsValid & loginsuccesfull)
            {               
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }
    }
}
