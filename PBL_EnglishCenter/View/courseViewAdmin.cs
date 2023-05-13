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
    public partial class courseViewAdmin : Form
    {
        private account currentAccount;
        public courseViewAdmin(account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            setGUI();
        }
        private void setGUI()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            // set hello + full name
            lb_fullname.Text = "Hello, " + (db.users.Find(currentAccount.user_id)).fullname;
            // set manage course dgv
            dgv_allcourse.DataSource = BLL.BLL.Instance.getListAllCourse().ToList();
        }
        private void bt_add_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
