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
    public partial class mainFormAdmin : Form
    {
        public delegate void DelMainFormAdmin();
        public DelMainFormAdmin DelAdmin1 { get; set; }
        private account currentAccount;
        public mainFormAdmin(account getAccount)
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
            dgvAnnAdm.DataSource = BLL.BLL.Instance.getListAllAnnouncement().ToList();
            
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DelAdmin1();
        }

        private void bt_profile_Click(object sender, EventArgs e)
        {
            profileManage profileForm = new profileManage(currentAccount);
            profileForm.Show();
        }

        private void bt_accountAdmin_Click(object sender, EventArgs e)
        {
            accountManage f = new accountManage();
            f.ShowDialog();
        }

        private void bt_courseAdmin_Click(object sender, EventArgs e)
        {
            courseViewAdmin courseViewAdminForm = new courseViewAdmin(currentAccount);
            courseViewAdminForm.ShowDialog();

        }
    }
}
