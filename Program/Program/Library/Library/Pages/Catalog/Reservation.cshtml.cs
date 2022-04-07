using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Library.Pages.Catalog
{
    public class ReservationModel : PageModel
    {
        public string msg;
        [BindProperty]
        private ReservationManagement Reservation { get; set; }
        [BindProperty]
        [Required]
        public int itemID { get; set; }
        [BindProperty]
        [Required]
        private int accountID { get; set; }

        [BindProperty]
        [Required]
        public DateTime date { get; set; }

        public IActionResult OnGet(int id)
        {
            try
            {
                itemID = id;
                return Page();
            }
            catch
            {
                return NotFound();
            }
        }

        public void OnPost()
        {
            Reservation = new ReservationManagement();
            accountID = Convert.ToInt32(User.FindFirst("id").Value);

            if (ModelState.IsValid)
            {
                if (Reservation.IsItemAvailble(itemID, date)<=0)
                    msg = "This item is already reserved for this date";
                else
                {
                    if (Reservation.MakeReservation(itemID, accountID, date))
                        msg = "Reservation succesfull created";
                    else msg = "Reservation is not succesfully created try again later ";
                }
            }
            else msg = "Something whent wrong try again later";
        }
    }
}
