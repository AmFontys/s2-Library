using Library_Class;
using Library_App.Views;

namespace Library_App
{
    public partial class Login : Form
    {
        private AccountManagement management= new  AccountManagement(new DBConnection());
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            bool loginsuccesfull = management.Login(email, pass,out string role,out string id);
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