using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Library.Pages.Detail.Management.Catalogue
{
    public class BookUpdateModel : PageModel
    {
        public string responseMessage { get; set; }

        [BindProperty][Required][RegularExpression(@"[0-9]{1,}", ErrorMessage ="There went something wrong please reclick the item that you wanted to update") ]
        public int itemID { get; set; }
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
        
        public Book? Book { get; set; }
        public IActionResult OnGet(int id,string? error)
        {
            if(id >=1)
            {
                Book = (Book)ItemManagement.SearchItem(id, 'B');
                itemID = id;
                if (error != null) responseMessage = error;
                return Page();
            }
            else
            {
                return RedirectToPage("/Catalogue");
            }
        }

        public IActionResult OnPost()
        {            
            if (ModelState.IsValid)
            {
                if (ItemManagement.UpdateItem(itemID, Name, ISBN, cost, Language, Description, Pages, Author, Publisher))
                {
                    return RedirectToPage("/Detail/Management/Catalogue/Catalogue");
                }
                else
                {
                    responseMessage = "Something whent wrong when updating check if the item still exists";
                    return this.OnGet(itemID, responseMessage);
                }
            }
            else
            {
                responseMessage = "";
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors))
                    responseMessage += item.ErrorMessage + "<br>";
                return this.OnGet(itemID,responseMessage);
            }
        }

    }
}
