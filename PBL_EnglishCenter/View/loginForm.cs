using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PBL_EnglishCenter.BLL;

namespace PBL_EnglishCenter.View
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            tb_password.UseSystemPasswordChar = true;
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            account temp = BLL.BLL.Instance.checkLogin(username, password);
            if (temp == null) 
            {
                MessageBox.Show("username or password is incorrect, try again!.");
            }
            else // login succeed
            {
                this.Hide();
                // check role to display mainform
                switch (temp.type.ToString().Trim())
                {
                    case "admin":
                        mainFormAdmin adForm = new mainFormAdmin(temp);
                        adForm.DelAdmin1 += new mainFormAdmin.DelMainFormAdmin(clear_info);
                        adForm.Show();
                        break;
                    case "teacher":
                        mainFormTeacher teaForm = new mainFormTeacher(temp);
                        teaForm.DelTeacher1 += new mainFormTeacher.DelMainFormTeacher(clear_info);
                        teaForm.Show();
                        break;
                    case "student":
                        mainFormStudent stuForm = new mainFormStudent(temp);
                        stuForm.DelStudent1 += new mainFormStudent.DelMainFormStudent(clear_info);
                        stuForm.ShowDialog();
                        
                        break;
                    default:
                        MessageBox.Show("Suprised Error! Try login later.");
                        break;
                }
            }
        }
        private void clear_info()
        {
            tb_username.Clear();
            tb_password.Clear();
            this.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_showpass_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar)
                tb_password.UseSystemPasswordChar = false;
            else
                tb_password.UseSystemPasswordChar = true;
        }
    }
}
