using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Library.Pages.Detail.Management.Catalogue
{
    public class BookInfoModel : PageModel
    {
        
        public string responseMessage { get; set; }

        [BindProperty][Required][DataType(DataType.Text)][RegularExpression(@"^[a-zA-Z0-9_\-\s]*$",ErrorMessage ="There are invalid charters in the name")]
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
        public string Language  { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"^[a-zA-Z0-9_\s]*$", ErrorMessage = "There are invalid charters in the description")]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "This is not an valid number")]
        public int Pages { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\-\s]*$", ErrorMessage = "There are invalid charters in the author name")]
        public string Author { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\-\s]*$", ErrorMessage = "There are invalid charters in the publishers name")]

        public string Publisher { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (ItemManagement.AddItem(Name,ISBN,cost,Language,Description,Pages,Author,Publisher))
                    responseMessage = "Item succesfully added";
                else responseMessage = "Item not succesfully added";
            }
            else
            {
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors))
                    responseMessage += item.ErrorMessage +"<br>";
            }
        }
    }
}
