using Library_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App.Views.Account
{
    public partial class CatalogueUpdate : UserControl
    {
        Item item = null;
        private static CatalogueUpdate _instance;
        public static CatalogueUpdate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CatalogueUpdate();
                }
                return _instance;
            }
        }

        public CatalogueUpdate()
        {
            InitializeComponent();           
        }

        public void LoadData(object data, char type)
        {
            MakeControlsDissapear();
            if (type == 'B') LoadDataBook((Book)data);
            else LoadDataMovie((Movie)data);
            item = (Item)data;
        }

        private void MakeControlsDissapear()
        {
            nudPages.Value = 1;
            nudTimeMin.Value = 1;
            //Book labels
            lblPages.Visible = false;
            lblAuthor.Visible = false;
            lblPublisher.Visible = false;
            //Movie labels
            lblProducer.Visible = false;
            lblTimeMin.Visible = false;
            lblDemographic.Visible = false;
            lblSubtitle.Visible = false;

            //Book Controls
            nudPages.Visible = false;
            txtAuthor.Visible = false;
            txtPublisher.Visible = false;

            //Movie Controls
            txtProducer.Visible=false;
            nudTimeMin.Visible=false;
            txtDemographic.Visible=false;
            txtSubtitle.Visible=false;
        }

        private void LoadDataMovie(Movie data)
        {
            MakeMovieControlsAppear();
            txtName.Text = data.GetName();
            txtISBN.Text = data.GetISBN();
            txtLanguage.Text = data.GetLanguage();
            txtCost.Text = data.GetCost().ToString();
            txtDescription.Text = data.GetDescription();
            txtProducer.Text = data.GetProducer();
            nudTimeMin.Value = data.GetTime();
            txtDemographic.Text = data.GetDemographic();
            txtSubtitle.Text = data.GetSubTitle();
        }

        private void MakeMovieControlsAppear()
        {
            //Movie labels
            lblProducer.Visible = true;
            lblTimeMin.Visible = true;
            lblDemographic.Visible = true;
            lblSubtitle.Visible = true;
            //Movie Controls
            txtProducer.Visible = true;
            nudTimeMin.Visible = true;
            txtDemographic.Visible = true;
            txtSubtitle.Visible = true;
        }

        private void LoadDataBook(Book data)
        {
            MakeBookControlsAppear();
            txtName.Text = data.GetName();
            txtISBN.Text = data.GetISBN();
            txtLanguage.Text = data.GetLanguage();
            txtCost.Text = data.GetCost().ToString();
            txtDescription.Text = data.GetLanguage();
            if(data.GetPages()<1)nudPages.Value = 1;
            else nudPages.Value = data.GetPages();
            txtAuthor.Text = data.GetAuthor();
            txtPublisher.Text = data.GetPublisher();
        }

        private void MakeBookControlsAppear()
        {
            //Book labels
            lblPages.Visible = true;
            lblAuthor.Visible = true;
            lblPublisher.Visible = true;
            //Book Controls
            nudPages.Visible = true;
            txtAuthor.Visible = true;
            txtPublisher.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool succes = false;
            string name = ValidateRegex(txtName.Text, @"^[a-zA-Z0-9_\-\s]*$", out succes) ;
            if (!succes) sb.Append("There are invalid charters in the name\n");

            string isbn = ValidateRegex(txtISBN.Text, @"^[0-9]{10,}$", out succes);
            if (!succes) sb.Append("There are invalid charters in the ISBN\n");

            double cost=0;
            if (!double.TryParse(txtCost.Text, out cost)) sb.Append("You didn't type a valid number in \n");

            string language = ValidateRegex(txtLanguage.Text,@"^[a-zA-Z\s]*$", out succes);
            if (!succes) sb.Append("There are invalid charters in the language\n");

            string description = ValidateRegex(txtDescription.Text, @"^[a-zA-Z0-9_\s\,\.]*$", out succes);
            if (!succes) sb.Append("There are invalid charters in the description\n");


            ItemManagement management = new ItemManagement(new DBConnection());
            if (nudPages.Value != 0 && nudTimeMin.Value == 1 && sb.Length <= 0)
            {
                int pages = (int)nudPages.Value;
                string author = ValidateRegex(txtAuthor.Text, @"^[a-zA-Z\-\s]*$", out succes );
                if (!succes) sb.Append("There are invalid charters in the author name\n");
                string publisher = ValidateRegex(txtPublisher.Text,@"^[a-zA-Z\-\s]*$",out succes );
                if (!succes) sb.Append( "There are invalid charters in the publishers name\n");

                if (sb.Length <= 0)
                {
                    management.UpdateItem(item.GetID(), name, isbn, cost, language, description, pages, author, publisher);
                    MessageBox.Show("Book succesfully updated");
                }
                else reportError(sb);
            }
            else if (nudPages.Value == 1 & nudTimeMin.Value != 0 & sb.Length <= 0)
            {
                string subTitle = ValidateRegex(txtSubtitle.Text, @"^[a-zA-Z\s\,]*$", out succes);
                if (!succes) sb.Append("There are invalid charters in the subtitlelanguage\n");
                string producer = ValidateRegex(txtProducer.Text, @"^[a-zA-Z\s]*$", out succes);
                if (!succes) sb.Append("There are invalid charters in the producers name\n");
                int time = (int)nudTimeMin.Value;
                string demographic = ValidateRegex(txtDemographic.Text, @"^[0-9]{1,3}$", out succes);
                if (!succes) sb.Append("The demographic is not between the ranges of 0-999\n");

                if (sb.Length <= 0)
                {
                    management.UpdateItem(item.GetID(), name, isbn, cost, language, description, subTitle, producer, time, demographic);
                    MessageBox.Show("Movie succesfully updated");
                }
                else reportError(sb);
            }
            else reportError(sb);
        }

        private void reportError(StringBuilder sb)
        {
            MessageBox.Show(sb.ToString());
        }

        private string ValidateRegex(string text, string regex,out bool succes)
        {
            Regex rng = new Regex(regex);
            if (rng.IsMatch(text))
            {
                succes = true;
                return text;
            }
            else
            {
                succes = false;
                return"";
            }
        }
    }
}
