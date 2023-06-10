using PBL_EnglishCenter.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL_EnglishCenter.View
{
    public partial class accountManage : Form
    {
        public accountManage()
        {
            InitializeComponent();
            start();
        }
        public void start()
        {

            cb_searchtype.Items.Add("All");
            cb_searchtype.Items.Add("student");
            cb_searchtype.Items.Add("teacher");
            cb_searchtype.Items.Add("admin");
            cb_searchtype.Text = "All";

            cb_type.Items.Add("student");
            cb_type.Items.Add("teacher");
            cb_type.Items.Add("admin");

            dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);
        }
        public void clear()
        {
            tb_username.Clear();
            cb_type.Text = string.Empty;
            tb_pass.Clear();
            tb_fullname.Clear();
            tb_gmail.Clear();
            tb_Phone.Clear();
            rb_female.Checked = false;
            rb_Male.Checked = false;
            cb_type.SelectedIndex = -1;

            clearlabel();
        }
        public void clearlabel()
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            tb_username.Enabled = true;
            cb_type.Enabled = true;
        }
        public bool check()
        {
            bool result = true;
            if (tb_username.Text == string.Empty)
            {
                result = false;
                label11.Visible = true;
            }
            if (BLL.BLL.Instance.checkAccount(tb_username.Text) > 0)
            {
                label5.Visible = true;
                result = false;
            }
            if (tb_pass.Text == string.Empty)
            {
                result = false;
                label6.Visible = true;
            }
            if (cb_type.Text == string.Empty)
            {
                result = false;
                label7.Visible = true;
            }
            if (tb_fullname.Text == string.Empty)
            {
                result = false;
                label8.Visible = true;
            }
            if (rb_female.Checked == false && rb_Male.Checked == false)
            {
                result = false;
                label9.Visible = true;
            }
            if (tb_Phone.Text == string.Empty)
            {
                result = false;
                label10.Visible = true;
            }
            if (tb_gmail.Text == string.Empty)
            {
                result = false;
                label12.Visible = true;
            }
            try
            {
                MailAddress test = new MailAddress(tb_gmail.Text);
            }
            catch (Exception) { label4.Visible = true; return false; }
            return result;
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            clearlabel();
            if (check())
            {

                user ustmp = new user();
                ustmp.fullname = tb_fullname.Text;
                if (rb_female.Checked)
                {
                    ustmp.gender = "Nữ";
                }
                else
                {
                    ustmp.gender = "Nam";
                }
                ustmp.gmail = tb_gmail.Text;
                ustmp.phone = tb_Phone.Text;
                BLL.BLL.Instance.addUser(ustmp);

                List<user> lstmp = BLL.BLL.Instance.getListAllUser();
                ustmp = lstmp[lstmp.Count - 1];
                account actmp = new account();
                actmp.username = tb_username.Text.ToString().Trim();
                actmp.password = tb_pass.Text.ToString().Trim();
                actmp.type = cb_type.Text.ToString().Trim();
                actmp.user_id = ustmp.id;
                BLL.BLL.Instance.addAccount(actmp);

                MessageBox.Show("Add success!");
                dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);
                clear();
            }
        }

        /*
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow r = dataGridView1.CurrentRow;
                int idtmp = Convert.ToInt16(r.Cells[0].Value);
                var message = "Are you sure to delete this account?";
                var title = "Warning!";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        BLL.BLL.Instance.deleteAccount(idtmp);
                        dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        MessageBox.Show("  ");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select account first!");
            }
        }
        */

        private void bt_edit_Click(object sender, EventArgs e)
        {
            clearlabel();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow r = dataGridView1.CurrentRow;

                user tmp = BLL.BLL.Instance.getUserbyAccID(
                    BLL.BLL.Instance.checkAccount(r.Cells["username"].Value.ToString()));
                user ustmp = new user();
                ustmp.id = tmp.id;
                ustmp.fullname = tb_fullname.Text.ToString().Trim();
                if (rb_female.Checked)
                {
                    ustmp.gender = "Nữ";
                }
                else
                {
                    ustmp.gender = "Nam";
                }
                ustmp.gmail = tb_gmail.Text.ToString().Trim();
                ustmp.phone = tb_Phone.Text.ToString().Trim();


                account tmp1 = BLL.BLL.Instance.getAccountById(
                    BLL.BLL.Instance.checkAccount(r.Cells["username"].Value.ToString()));
                account actmp = new account();
                actmp.id = tmp1.id;
                actmp.username = tb_username.Text.ToString().Trim();
                actmp.password = tb_pass.Text.ToString().Trim();
                actmp.type = cb_type.Text.ToString().Trim();
                actmp.user_id = ustmp.id;

                BLL.BLL.Instance.updateUser(ustmp);
                BLL.BLL.Instance.updateAccount(actmp);

                MessageBox.Show("Update success!");
                dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);

            }
            else
            {
                MessageBox.Show("Select account first!");
            }
            clear();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            clearlabel();
            if (cb_searchtype.Text == "All")
            {
                dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);
            }
            else
            {
                //dataGridView1.DataSource = BLL.BLL.Instance.getListAllTypeAccount(cb_searchtype.Text);
                dataGridView1.DataSource = BLL.BLL.Instance.getSearchAccount(cb_searchtype.Text, tb_search.Text);
            }
            clear();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            clearlabel();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow r = dataGridView1.CurrentRow;

                //user ustmp = BLL.BLL.Instance.getUserById(Convert.ToInt32(r.Cells["user_id"].Value));
                user ustmp = BLL.BLL.Instance.getUserbyAccID(
                    BLL.BLL.Instance.checkAccount(r.Cells["username"].Value.ToString()));
                tb_fullname.Text = ustmp.fullname;
                if (ustmp.gender == "Nữ")
                {

                    rb_female.Checked = true;
                }
                else
                {
                    rb_Male.Checked = true;
                }
                tb_gmail.Text = ustmp.gmail.ToString().Trim();
                tb_Phone.Text = ustmp.phone.ToString().Trim();
                tb_username.Text = r.Cells["username"].Value.ToString().Trim();
                tb_pass.Text = r.Cells["password"].Value.ToString().Trim();
                string tmp = r.Cells["type"].Value.ToString().Trim();
                cb_type.Text = r.Cells["type"].Value.ToString().Trim(); ;
                tb_username.Enabled = false;
                cb_type.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select account first!");
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (cb_type.Text == "")
            {
                cb_type.Text = "student";
                rb_Male.Checked = true;
            }

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
