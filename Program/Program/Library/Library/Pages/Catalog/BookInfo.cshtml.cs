using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Catalog
{
    public class BookInfoModel : PageModel
    {
        public Book book { get; set; }
        public IActionResult OnGet(int id)
        {
            ItemManagement management = new ItemManagement(new DBConnection());
            book = (Book)management.SearchItem(id, 'B');
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
