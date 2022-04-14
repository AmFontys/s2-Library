using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Library.Pages.Detail.Management.Catalogue
{
    public class MovieNewModel : PageModel
    {
        public string responseMessage { get; set; }
        private ItemManagement management { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z0-9_\-\s]*$", ErrorMessage = "There are invalid charters in the name")]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]{10,}$", ErrorMessage = "There are invalid charters in the ISBN")]
        public string ISBN { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Currency)]
        public double cost { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "There are invalid charters in the language")]
        public string Language { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"^[a-zA-Z0-9_\s]*$", ErrorMessage = "There are invalid charters in the description")]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "There are invalid charters in the subtitlelanguage")]
        public string SubtitleLanguage { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "There are invalid charters in the producers name")]
        public string Producer { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]{1,3}$", ErrorMessage = "The time is not between the ranges of 0-999")]
        public int timeInMin { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]{1,3}$", ErrorMessage = "The demographic is not between the ranges of 0-999")]
        public string Demographic { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                management = new ItemManagement(new DBConnection());
                if (management.AddItem(Name, ISBN, cost, Language, Description,SubtitleLanguage,Producer,timeInMin,Demographic))
                    responseMessage = "Item succesfully added";
                else responseMessage = "Item not succesfully added";
            }
            else
            {
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors))
                    responseMessage += item.ErrorMessage + "<br>";
            }
        }
    }
}
