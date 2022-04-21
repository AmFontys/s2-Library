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
        private ItemManagement management = new ItemManagement(new DBConnection());
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
            cmbSeacrh.SelectedIndex = 1;
            lbView.Items.Clear();
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
            MainForm.Instance.BringNewCatalogueToFront();
            makeButtonsDissapear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Item item = (Item)storage;
            if (management.DeleteItem(item.GetID()) > 0) MessageBox.Show("Item Deleted");
            else MessageBox.Show("This item is already deleted");
            lbView.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainForm.Instance.BringUpdateCatalogueToFront(storage,type);
            makeButtonsDissapear();
        }

        private void btnBookLoad_Click(object sender, EventArgs e)
        {
            makeButtonsDissapear();
            type = 'B';

            List<Book> books = new List<Book>();
            books = management.GetAllItems();
            InsertToViewBook(books);
        }

        private void btnMovieLoad_Click(object sender, EventArgs e)
        {
            makeButtonsDissapear();
            type = 'M';

            List<Movie> movies = management.GetAllItem();
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
                if (type == 'B')
                {
                    storage = (Book)currentRow;
                }
                else if(type == 'M')
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == null) return;
            if (cmbSeacrh.Text == null || cmbSeacrh.Text == "") return;

            List<object> data= management.SearchItem(txtSearch.Text, cmbSeacrh.Text, type);
            if (type == 'B')
            {
                List<Book> books = new List<Book>();
                foreach(Book book in data)
                {
                    books.Add(book);
                }
                InsertToViewBook(books);
            }
            else if (type == 'M')
            {
                List<Movie> movies= new List<Movie>();
                foreach(Movie movie in data)
                    movies.Add(movie);
                InsertToViewMovie(movies);
            }
        }

        private void cmbSortOn_TextChanged(object sender, EventArgs e)
        {
            object[] NewList;
            if (type == 'B')
            {
                NewList = new Book[lbView.Items.Count];
            }
            else NewList = new Movie[lbView.Items.Count];
            lbView.Items.CopyTo(NewList,0);
            if (type == 'B')
            {
                Book[] bookArray = (Book[])SortArray((Book[])NewList, cmbSortOn.Text);
                InsertToViewBook(bookArray.ToList());
            }
            else if (type == 'M')
            {
                Movie[] movieArray = (Movie[])SortArray(cmbSortOn.Text, (Movie[])NewList);
                InsertToViewMovie(movieArray.ToList());
            }
            else return;
        }

        private object[] SortArray(Book[] array,string sortOn)
        {
            object[] newList = array;
           
            switch (sortOn)
            {
                case "Name":
                    newList = array.OrderBy(x => x.GetName()).ToArray();
                    break;
                case "ISBN":
                    newList = array.OrderBy(x => x.GetISBN()).ToArray();
                    break;
                case "Description":
                    newList = array.OrderBy(x => x.GetDescription()).ToArray();
                    break;
                case "Language":
                    newList = array.OrderBy(x => x.GetLanguage()).ToArray();
                    break;
            }
            return newList;
        }

        private object[] SortArray(string sortOn,Movie[] array)
        {
            object[] newList = array;

            switch (sortOn)
            {
                case "Name":
                    newList = array.OrderBy(x => x.GetName()).ToArray();
                    break;
                case "ISBN":
                    newList = array.OrderBy(x => x.GetISBN()).ToArray();
                    break;
                case "Description":
                    newList = array.OrderBy(x => x.GetDescription()).ToArray();
                    break;
                case "Language":
                    newList = array.OrderBy(x => x.GetLanguage()).ToArray();
                    break;
            }
            return newList;
        }
    }
}
