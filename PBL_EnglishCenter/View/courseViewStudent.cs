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
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            // set hello + full name
            lb_fullname.Text = "Hello, " + (db.users.Find(currentAccount.user_id)).fullname;
            // set ann dgv
            dgv_courseStu.DataSource = BLL.BLL.Instance.getListCourseByStudentId((int)currentAccount.user_id).ToList();

        }
    }
}
