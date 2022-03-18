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
    public partial class CatalogueOverview : UserControl
    {
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
    }
}