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
    public partial class GunaSample : Form
    {
        public GunaSample()
        {
            InitializeComponent();
        }

        private void GunaSample_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = BLL.BLL.Instance.customDGVCourseViewAdm();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
