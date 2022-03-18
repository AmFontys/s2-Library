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
    public partial class OpeningHourOverview : UserControl
    {
        private static OpeningHourOverview _instance;
        public static OpeningHourOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OpeningHourOverview();
                }
                return _instance;
            }
        }

        public OpeningHourOverview()
        {
            InitializeComponent();
        }
    }
}
