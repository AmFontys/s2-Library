using Library_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string name = txtName.Text;
            string isbn = txtISBN.Text;
            double cost = Convert.ToDouble(txtCost.Text);
            string language = txtLanguage.Text;
            string description = txtDescription.Text;


            ItemManagement management = new ItemManagement(new DBConnection());
            if (nudPages.Value != 0 && nudTimeMin.Value == 1) {
                int pages = (int)nudPages.Value;
                string author = txtAuthor.Text;
                string publisher = txtPublisher.Text;
                management.UpdateItem(item.GetID(), name, isbn, cost, language, description, pages, author, publisher);
                MessageBox.Show("Book succesfully updated");
            }
            else if (nudPages.Value == 1 & nudTimeMin.Value !=0) {
                string subTitle = txtSubtitle.Text;
                string producer = txtProducer.Text;
                int time = (int)nudTimeMin.Value;
                string demographic = txtDemographic.Text;
                management.UpdateItem(item.GetID(), name, isbn, cost, language, description, subTitle, producer, time, demographic);
                MessageBox.Show("Movie succesfully updated");
            }
        }
    }
}
