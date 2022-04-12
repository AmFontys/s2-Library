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
    public partial class CatalogueOverview : UserControl
    {
        object storage;
        char type;
        private static CatalogueOverview _instance;
        public static CatalogueOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CatalogueOverview();
                }
                return _instance;
            }
        }
        public CatalogueOverview()
        {
            InitializeComponent();
        }

        public void InsertToViewBook(List<Book> data)
        {
            lbView.Items.Clear();
            foreach (Book book in data)
            {
                lbView.Items.Add(book);
            }
        }

        public void InsertToViewMovie(List<Movie> data)
        {
            lbView.Items.Clear();
            foreach (Movie movie in data)
            {
                lbView.Items.Add(movie);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBookLoad_Click(object sender, EventArgs e)
        {
            makeButtonsDissapear();
            type = 'b';

            List<Book> books = new List<Book>();
            books = ItemManagement.GetAllItems();
            InsertToViewBook(books);
        }

        private void btnMovieLoad_Click(object sender, EventArgs e)
        {
            makeButtonsDissapear();
            type = 'm';

            List<Movie> movies = ItemManagement.GetAllItem();
            InsertToViewMovie(movies);

        }

        private void dgView_Click(object sender, EventArgs e)
        {
            makeButtonsDissapear();
        }

        private void makeButtonsDissapear()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void dgView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object currentRow = lbView.SelectedItem;
                if (type == 'b')
                {
                    storage = (Book)currentRow;
                }
                else if(type == 'm')
                {
                    storage= (Movie)currentRow;
                }
                btnUpdate.Visible = true;
                btnDelete.Visible=true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
