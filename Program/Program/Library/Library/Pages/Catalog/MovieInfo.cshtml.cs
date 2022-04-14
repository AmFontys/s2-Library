using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Catalog
{
    public class MovieInfoModel : PageModel
    {
        public Movie movie { get; set; }
        public IActionResult OnGet(int id)
        {
            ItemManagement management = new ItemManagement(new DBConnection());
            movie = (Movie)management.SearchItem(id, 'M');
            if (movie == null)
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
