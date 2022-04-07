using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.Catalog
{
    public class MoviesModel : PageModel
    {
        [BindProperty]
        public List<Movie> movies { get; set; }
        public void OnGet()
        {
            movies = Movie.GetAllMovies();
        }
    }
}
