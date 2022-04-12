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
            books = ItemManagement.GetAllItems();
            movies = ItemManagement.GetAllItem();
        }

        public IActionResult onGetDelete(int? id)
        {
            if (id != null & id < 1)
            {
                int result = ItemManagement.DeleteItem(id);
                if (result == 0)
                {
                    msg = "The item is already deleted or something whent wrong when executing";
                    return Page();
                }
                else
                {
                    msg = "Item succesfully deleted";
                    return Page();
                }
            }
            else
            {
                msg = "There are no items with this id";
                return Page();
            }
        }
    }
}
