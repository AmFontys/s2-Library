using Library_App.Views.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App.Views
{
    public partial class MainForm : Form
    {
        private static MainForm _instance=null;
        public static MainForm Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(WorkerOverview.Instance))
            {
                panelContentHolder.Controls.Add(WorkerOverview.Instance);
                WorkerOverview.Instance.Dock = DockStyle.Fill;
            }
            WorkerOverview.Instance.BringToFront();
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(CatalogueOverview.Instance))
            {
                panelContentHolder.Controls.Add(CatalogueOverview.Instance);
                CatalogueOverview.Instance.Dock = DockStyle.Fill;
            }
            CatalogueOverview.Instance.BringToFront();
        }

        public void BringNewCatalogueToFront()
        {
            if (!panelContentHolder.Controls.Contains(CatalogueNew.Instance))
            {
                panelContentHolder.Controls.Add(CatalogueNew.Instance);
                CatalogueNew.Instance.Dock = DockStyle.Fill;                
            }
                CatalogueNew.Instance.BringToFront();
            CatalogueNew.Instance.emptyForm();
        }
        public void BringUpdateCatalogueToFront(object data, char type)
        {
            if (!panelContentHolder.Controls.Contains(CatalogueUpdate.Instance))
            {
                panelContentHolder.Controls.Add(CatalogueUpdate.Instance);
                CatalogueUpdate.Instance.Dock = DockStyle.Fill;
            }
            CatalogueUpdate.Instance.BringToFront();
            CatalogueUpdate.Instance.LoadData(data, type);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(EventOverview.Instance))
            {
                panelContentHolder.Controls.Add(EventOverview.Instance);
                EventOverview.Instance.Dock = DockStyle.Fill;
            }
            EventOverview.Instance.BringToFront();
        }

        private void btnOpeningHour_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(OpeningHourOverview.Instance))
            {
                panelContentHolder.Controls.Add(OpeningHourOverview.Instance);
                OpeningHourOverview.Instance.Dock = DockStyle.Fill;
            }
            OpeningHourOverview.Instance.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(AccountOverview.Instance))
            {
                panelContentHolder.Controls.Add(AccountOverview.Instance);
                AccountOverview.Instance.Dock = DockStyle.Fill;

            }
            AccountOverview.Instance.BringToFront();
        }
    }
}
