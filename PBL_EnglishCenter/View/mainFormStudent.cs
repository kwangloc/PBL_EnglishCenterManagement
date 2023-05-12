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
    public partial class mainFormStudent : Form
    {
        public delegate void DelMainFormStudent();
        public DelMainFormStudent DelStudent1 { get; set; }
        public mainFormStudent()
        {
            InitializeComponent();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelStudent1();
        }
    }
}
