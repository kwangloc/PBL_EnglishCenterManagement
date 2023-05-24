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
    public partial class announcementManage : Form
    {
        public announcementManage()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                announcement tempAnn = new announcement
                {
                    name = tb_title.Text,
                    description = rtb_des.Text,
                    course_id = Convert.ToInt32(tb_courseId.Text)
                };
                BLL.BLL.Instance.addAnnouncement(tempAnn);
            }
            catch
            {
                MessageBox.Show("Fill all required information");
            }
            this.Dispose();
        }
    }
}
