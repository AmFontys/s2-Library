using Library.Class;
using Library_App.Views;

namespace Library_App
{
    public partial class Login : Form
    {
        Account Account { get; set; }
        public Login()
        {
            InitializeComponent();
            Account=new Account();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string pass = txtPass.Text;
            bool loginsuccesfull = Account.Login(fname, lname, pass);
            if (loginsuccesfull)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                lblOutput.Text = "Login unsuccesfull check if you entered the correct credatianls";
            }
        }
    }
}