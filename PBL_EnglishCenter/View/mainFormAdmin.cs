﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_EnglishCenter.View
{
    public partial class mainFormAdmin : Form
    {
        public delegate void DelMainFormAdmin();
        public DelMainFormAdmin DelAdmin1 { get; set; }
        public mainFormAdmin()
        {
            InitializeComponent();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelAdmin1();
        }
    }
}
