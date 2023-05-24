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
        private account currentAccount;
        public mainFormStudent(account getAccount)
        {
            InitializeComponent();
            this.currentAccount = getAccount;
            setGUI();
        }
        private void setGUI()
        {
            // set hello + full name
            lb_fullname.Text = "Hello, " + (BLL.BLL.Instance.getUserById((int)currentAccount.user_id)).fullname;
            // set ann dgv
            dgvAnnStu.DataSource = BLL.BLL.Instance.customDGVAnnInMainFormStu((int)currentAccount.user_id);
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelStudent1();
        }

        private void bt_profile_Click(object sender, EventArgs e)
        {
            profileManage profileForm = new profileManage(currentAccount);
            profileForm.Show();
        }

        private void bt_courseStudent_Click(object sender, EventArgs e)
        {
            courseViewStudent courseViewStudentForm = new courseViewStudent(currentAccount);
            courseViewStudentForm.ShowDialog();
        }
    }
}
