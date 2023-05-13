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
        private account currentAccount;
        public mainFormTeacher(account getAccount)
        {
            InitializeComponent();
            this.currentAccount = getAccount;
            setGUI();
        }
        private void setGUI()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            lb_fullname.Text = "Hello, " + (db.users.Find(currentAccount.user_id)).fullname;
            // set ann dgv
            dgvAnnTea.DataSource = BLL.BLL.Instance.getListAnnouncementByTeacherId((int)currentAccount.user_id).ToList();
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelTeacher1();
        }
    }
}
