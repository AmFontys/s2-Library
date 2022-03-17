using Library.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Catalog
{
    public class BookInfoModel : PageModel
    {
        public Book book { get; set; }
        public IActionResult OnGet(int id)
        {
            book = Book.SearchBookByID(id);
            if(book == null)
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
