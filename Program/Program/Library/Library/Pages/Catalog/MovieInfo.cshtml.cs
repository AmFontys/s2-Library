using Library.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Catalog
{
    public class MovieInfoModel : PageModel
    {
        public Movie movie { get; set; }
        public IActionResult OnGet(int id)
        {
            movie = Movie.SearchMovieByID(id);
            if(movie == null)
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
