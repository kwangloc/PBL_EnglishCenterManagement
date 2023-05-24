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
    public partial class courseViewStudent : Form
    {
        private account currentAccount;
        public courseViewStudent(account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            setGUI();
        }
        private void setGUI()
        {
            // set hello + full name
            lb_fullname.Text = "Hello, " + (BLL.BLL.Instance.getUserById((int)currentAccount.user_id)).fullname;
            // set ann dgv
            dgv_courseStu.DataSource = BLL.BLL.Instance.customDGVCourseViewStu((int)currentAccount.user_id);
            dgv_courseStu.Columns["ID"].Visible = false;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_viewCourseDetails_Click(object sender, EventArgs e)
        {
            if(dgv_courseStu.SelectedRows.Count == 1)
            {
                int courseId = Convert.ToInt32(dgv_courseStu.SelectedRows[0].Cells["ID"].Value);
                courseDetailsViewStudent cdvsForm = new courseDetailsViewStudent(BLL.BLL.Instance.getCourseByCourseID(courseId), currentAccount);
                cdvsForm.ShowDialog();
            }
        }
    }
}
