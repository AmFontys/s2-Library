using Library_Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Library.Pages.Detail.User
{
    public class PersonalUpdateModel : PageModel
    {
        public string msg;
        Regex regex;
        [BindProperty]
        public Account Account{get;set;}

        [BindProperty]
        [Required]
        private int id { get;set;}
        [BindProperty]
        [Required]
        public string Fname { get; set; }
        [BindProperty]
        [Required]
        public string Lname { get; set; }
        [BindProperty]
        [Required]
        public string Email { get; set; }
        [BindProperty]
        [Required]
        public string Telephone { get; set; }
        [BindProperty]
        [Required]
        public string Street { get; set; }
        [BindProperty]
        [Required]
        public string HouseNum { get; set; }
        [BindProperty]
        [Required]
        public string Zipcode { get; set; }
        [BindProperty]
        [Required]
        public string City { get; set; }
        [BindProperty]        
        public string Password { get; set; }

        public void OnGet()
        {
            AccountManagement management = new AccountManagement(new DBConnection());
            Account = management.FindAccount(GetID());
        }

        public void OnPost()
        {
            id=GetID();
            bool valid = validateInput(out string error);
            if (Password == null) ModelState["Password"].ValidationState = ModelValidationState.Valid;
            if (ModelState.IsValid)
            {
                AccountManagement management = new AccountManagement(new DBConnection());
                if (management.UpdateAccount(id, Fname, Lname, Email, Telephone, Street, HouseNum, Zipcode, City, Password))
                {
                    msg = $"Your account is updated";
                }
                else msg = $"Your account isn't succesfully updated";
            }
            else
            {
                msg = $"You gave some invalid inputs please give valid input " +
                    $" {error}";
            }
        }

        private int GetID()
        {
            return Convert.ToInt32(User.FindFirst("id").Value);
        }

        private bool validateInput(out string error)
        {
            if (ValidateString(Fname) == false)
            {
                error = "The first name has invalid charters \n";
                return false;
            }
            else if (ValidateString(Lname) == false)
            {
                error = "The Last name has invalid charters \n";
                return false;
            }
            else if (ValidateEmail(Email) == false)
            {
                error = "The email is invalid \n";
                return false;
            }
            else if (ValidateTelephone(Telephone) == false)
            {
                error = "Your telephone number is not valid \n";
                return false;
            }
            else if (ValidateHouseNum(HouseNum) == false)
            {
                error = "Your house number is invalid \n";
                return false;
            }
            else if (ValidateZipcode(Zipcode, out string zipError) == false)
            {
                error = zipError;
                return false;
            }
            else if (ValidateString(City) == false)
            {
                error = "Your city contains invalid charters \n";
                return false;
            }
            else if (ValidatePass(Password) == false)
            {
                error = "Your password must not begin with a space, minus symbol and needs to be atleast 8 charters long \n";
                return false;
            }
            else
            {
                error = "";
                return true;
            }
        }

        private bool ValidatePass(string password)
        {
            if (password == null || password == "") return true;
            regex = new Regex(@"^[^-\s]*[a-zA-Z\d]{8,}");
            if (regex.IsMatch(password))
            {
                return true;
            }
            else return false;

        }

        private bool ValidateZipcode(string zipcode, out string zipError)
        {
            /*A list of where the zipcodes for the following country is valid
             * US
             * CA
             * DE
             * JP
             * NL
             * BE
             * GB
             */
            List<string> list = new List<string>()
            {
                @"\d{ 5} ([ \-]\d{ 4})?",
                @"[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJ-NPRSTV-Z][ ]?\d[ABCEGHJ-NPRSTV-Z]\d",
                @"\d{5}",
                @"\d{3}-\d{4}",
                @"\d{4}[ ]?[A-Z]{2}",
                @"\d{4}",
                @"GIR[ ]?0AA|((AB|AL|B|BA|BB|BD|BH|BL|BN|BR|BS|BT|CA|CB|CF|CH|CM|CO|CR|CT|CV|CW|DA|DD|DE|DG|DH|DL|DN|DT|DY|E|EC|EH|EN|EX|FK|FY|G|GL|GY|GU|HA|HD|HG|HP|HR|HS|HU|HX|IG|IM|IP|IV|JE|KA|KT|KW|KY|L|LA|LD|LE|LL|LN|LS|LU|M|ME|MK|ML|N|NE|NG|NN|NP|NR|NW|OL|OX|PA|PE|PH|PL|PO|PR|RG|RH|RM|S|SA|SE|SG|SK|SL|SM|SN|SO|SP|SR|SS|ST|SW|SY|TA|TD|TF|TN|TQ|TR|TS|TW|UB|W|WA|WC|WD|WF|WN|WR|WS|WV|YO|ZE)(\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}))|BFPO[ ]?\d{1,4}"
            };
            Regex regex;
            foreach (var item in list)
            {
                regex = new Regex(item);
                if (regex.IsMatch(zipcode))
                {
                    zipError = "";
                    return true;
                }
            }

            zipError = "There is no match with any zipcode that we use \n";
            return false;
        }

        private bool ValidateHouseNum(string houseNum)
        {
            regex = new Regex(@"^\d[\.]?[\d]?[A-Z]*");
            if (regex.IsMatch(houseNum)) return true;
            else return false;

        }

        private bool ValidateTelephone(string telephone)
        {
            regex = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
            if (regex.IsMatch(telephone))
            {
                return true;
            }
            else return false;
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (regex.IsMatch(email)) return true;
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        private bool ValidateString(string validatestring)
        {
            char[] invalidChars = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ';', '/', '?', ':', '`', '~', '+', '%', '_' };

            if (string.IsNullOrEmpty(validatestring)) return false;
            if (validatestring.IndexOfAny(invalidChars) == -1) return true;
            else return false;
        }
    }
} 
