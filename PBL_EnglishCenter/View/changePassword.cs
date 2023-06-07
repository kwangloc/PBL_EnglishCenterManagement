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
    public partial class changePassword : Form
    {
        private account currentAccount;
        public changePassword(account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            setGUI();
        }
        private void setGUI()
        {
            lb_showUser.Text = currentAccount.username;
            lb_showType.Text = currentAccount.type;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string username = lb_showUser.Text;
            string password = tb_currentPassword.Text;
            account temp = BLL.BLL.Instance.checkLogin(username, password);

            //dont fill in all the information
            if (string.IsNullOrEmpty(tb_currentPassword.Text) 
                || string.IsNullOrEmpty(tb_newPassword.Text) 
                || string.IsNullOrEmpty(tb_confirmPassword.Text))
            {
                MessageBox.Show("You must fill in all the information, try again!",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            //Current Password is incorrect
            else if (temp == null)
            {
                MessageBox.Show("Current Password is incorrect, try again!",
                    "", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            //Current Password is correct
            else
            {
                //New Password and Confirm Password not be the same
                if (tb_newPassword.Text.Equals(tb_confirmPassword.Text) == false)
                {
                    
                    MessageBox.Show("Confirm password is incorrect, try again!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                //New Password and Current Password be the same
                else if (tb_newPassword.Text.Equals(tb_currentPassword.Text))
                {
                    MessageBox.Show("New Password and Current Password must not be the same!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                //Change password successfully
                else
                {
                    //save      
                    temp.id = currentAccount.user.id;
                    temp.password = tb_newPassword.Text;
                    BLL.BLL.Instance.saveAccount(temp);
                    MessageBox.Show("Change password successfully.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
