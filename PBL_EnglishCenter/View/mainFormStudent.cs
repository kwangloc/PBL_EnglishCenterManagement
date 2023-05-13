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
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            // set hello + full name
            lb_fullname.Text = "Hello, " + (db.users.Find(currentAccount.user_id)).fullname;
            // set ann dgv
            dgvAnnStu.DataSource = BLL.BLL.Instance.getListAnnouncementByStudentId((int)currentAccount.user_id).ToList();
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelStudent1();
        }
    }
}
