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
    public partial class courseViewTeacher : Form
    {
        private account currentAccount;
        public courseViewTeacher(account currentAccount)
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
            dgv_courseStu.DataSource = BLL.BLL.Instance.getListCourseByTeacherId((int)currentAccount.user_id).ToList();

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
