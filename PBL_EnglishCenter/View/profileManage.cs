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
    public partial class profileManage : Form
    {
        private account currentAccount;
        public profileManage(account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            setGUI();
        }
        private void setGUI()
        {
            // set name profile
            lb_fullname.Text = currentAccount.user.fullname + "'s Profile";
            // fill text box
            tb_fullname.Text = currentAccount.user.fullname;
            if(currentAccount.user.gender.Equals("Nam"))
            {
                rb_male.Checked = true;
            }
            else
            {
                rb_female.Checked = true;
            }
            tb_phone.Text = currentAccount.user.phone;
            tb_gmail.Text = currentAccount.user.gmail;
            tb_type.Text = currentAccount.type;
            tb_username.Text = currentAccount.username;
            tb_password.Text = currentAccount.password;
            if(currentAccount.type.Trim().Equals("teacher"))
            {
                lb_detailsInfo.Text = "Degree";
                tb_detailsInfo.Text = (BLL.BLL.Instance.getTeacherInfoByUserId((int)currentAccount.user_id)).degree;
            }
            else if(currentAccount.type.Trim().Equals("student"))
            {
                lb_detailsInfo.Text = "Parent Phone";
                tb_detailsInfo.Text = (BLL.BLL.Instance.getStudentInfoByUserId((int)currentAccount.user_id)).parent_phone;
            }
            else
            {
                lb_detailsInfo.Hide();
                tb_detailsInfo.Hide();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //save user
            user tempUser = new user();
            tempUser.id = currentAccount.user.id;
            tempUser.fullname = tb_fullname.Text.Trim();
            tempUser.gender = (rb_male.Checked) ? "Nam" : "Nữ";
            tempUser.phone = tb_phone.Text.Trim();
            tempUser.gmail = tb_gmail.Text.Trim();
            BLL.BLL.Instance.saveUser(tempUser);
            //save account
            account tempAccount = new account();
            tempAccount.id = currentAccount.user.id;
            tempAccount.password = tb_password.Text.Trim();
            BLL.BLL.Instance.saveAccount(tempAccount);
            //save details Info
            if (currentAccount.type.Trim().Equals("teacher"))
            {
                teacher_info tempTeacherInfo = new teacher_info();
                tempTeacherInfo.id = currentAccount.user.id;
                tempTeacherInfo.degree = tb_detailsInfo.Text.Trim();
                BLL.BLL.Instance.saveDegree(tempTeacherInfo);
            }
            else if (currentAccount.type.Trim().Equals("student"))
            {
                student_info tempStudentInfo = new student_info();
                tempStudentInfo.id = currentAccount.id;
                tempStudentInfo.parent_phone = tb_detailsInfo.Text.Trim();
                BLL.BLL.Instance.saveParentPhone(tempStudentInfo);
            }
            this.Dispose();
        }
    }
}
