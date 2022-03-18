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
    public partial class EventOverview : UserControl
    {
        private static EventOverview _instance;
        public static EventOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventOverview();
                }
                return _instance;
            }
        }
        public EventOverview()
        {
            InitializeComponent();
        }
    }
}
