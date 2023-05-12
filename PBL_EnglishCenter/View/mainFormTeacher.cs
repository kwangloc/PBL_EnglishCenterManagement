using System;
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
    public partial class mainFormTeacher : Form
    {
        public delegate void DelMainFormTeacher();
        public DelMainFormTeacher DelTeacher1 { get; set; }
        public mainFormTeacher()
        {
            InitializeComponent();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelTeacher1();
        }
    }
}
