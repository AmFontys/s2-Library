﻿using System;
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
    public partial class WorkerOverview : UserControl
    {
        private static WorkerOverview _instance;
        public static WorkerOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WorkerOverview();
                }
                return _instance;
            }
        }
        public WorkerOverview()
        {
            InitializeComponent();
        }
    }
}
