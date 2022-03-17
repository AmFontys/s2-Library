using Library.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Library.Pages.Catalog
{
    public class BooksModel : PageModel
    {
        [BindProperty]
        public List<Book> books { get; set; }
        public void OnGet()
        {
            books = new List<Book>();
           books= Book.GetAllBooks();
            
        }

       
    }
}
