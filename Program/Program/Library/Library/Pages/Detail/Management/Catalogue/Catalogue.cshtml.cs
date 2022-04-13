using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Detail.Management.Catalogue
{
    public class CatalogueModel : PageModel
    {
        [BindProperty]
        public List<Book> books { get; set; }
        [BindProperty]
        public List<Movie> movies { get; set; }
        [BindProperty]
        public string msg { get; set; }
        public void OnGet()
        {
            loadView();
        }

        public IActionResult OnGetDelete(int? id)
        {
            loadView();
            if (id != null & id > 1)
            {
                int result = ItemManagement.DeleteItem(id);
                if (result == 0)
                {
                   return RedirectToPage("./Catalogue");
                }
                else
                {
                   return RedirectToPage("./Catalogue");
                }
            }
            else
            {
                return RedirectToPage("./Catalogue");
            }
        }

        private void loadView()
        {
            books = ItemManagement.GetAllItems();
            movies = ItemManagement.GetAllItem();
        }
    }
}
