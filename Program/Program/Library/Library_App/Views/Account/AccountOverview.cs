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
    public partial class AccountOverview : UserControl
    {
        private static AccountOverview _instance;
        public static AccountOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountOverview();
                }
                return _instance;
            }
        }
        public AccountOverview()
        {
            InitializeComponent();
        }
    }
}
