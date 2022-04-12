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
        public CatalogueUpdate(List<string> data,char type)
        {
            InitializeComponent();
            MakeControlsDissapear();
            if (type == 'b') LoadDataBook();
            else LoadDataMovie();
        }

        private void MakeControlsDissapear()
        {
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

        private void LoadDataMovie()
        {
            MakeMovieControlsAppear();
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

        private void LoadDataBook()
        {
            MakeBookControlsAppear();
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

        }
    }
}
