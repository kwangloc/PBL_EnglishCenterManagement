﻿using PBL_EnglishCenter.DTO;
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

        }
        public void clear()
        {
            
            tb_username.Clear();
            cb_type.Text= string.Empty;
            tb_pass.Clear();
            tb_pass2.Clear();
            tb_fullname.Clear();
            tb_gmail.Clear();
            tb_Phone.Clear();
            rb_female.Checked = false;
            rb_Male.Checked = false;

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            //try catch chua them 

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
            actmp.username = tb_username.Text.ToString();
            actmp.password = tb_pass.Text.ToString();
            actmp.type = cb_type.Text.ToString();
            actmp.user_id = ustmp.id;
            BLL.BLL.Instance.addAccount(actmp);

            dataGridView1.DataSource = BLL.BLL.Instance.getListAllAccount();
            clear();
        }
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


        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow r = dataGridView1.CurrentRow;

                user ustmp = new user();
                ustmp.fullname = tb_fullname.Text.ToString();
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
                ustmp.id = Convert.ToInt32(r.Cells[5].Value);

                account actmp = new account();
                actmp.id = Convert.ToInt32(r.Cells[0].Value);
                actmp.username = tb_username.Text.ToString();
                actmp.password = tb_pass.Text.ToString();
                actmp.type = cb_type.Text.ToString();
                actmp.user_id = ustmp.id;

                BLL.BLL.Instance.updateUser(ustmp);
                BLL.BLL.Instance.updateAccount(actmp);

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
            if (cb_searchtype.Text == "All")
            {
                dataGridView1.DataSource = BLL.BLL.Instance.getAllAccount(tb_search.Text);
            }
            else
            {
                //dataGridView1.DataSource = BLL.BLL.Instance.getListAllTypeAccount(cb_searchtype.Text);
                dataGridView1.DataSource = BLL.BLL.Instance.getSearchAccount(cb_searchtype.Text,tb_search.Text);
            }
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow r = dataGridView1.CurrentRow;
                user ustmp = BLL.BLL.Instance.getUserById(Convert.ToInt32(r.Cells["user_id"].Value));
                tb_fullname.Text = ustmp.fullname;
                if (ustmp.gender == "Nữ")
                {

                    rb_female.Checked = true;
                }
                else
                {
                    rb_Male.Checked = true;
                }
                tb_gmail.Text = ustmp.gmail;
                tb_Phone.Text = ustmp.phone;
                tb_username.Text = r.Cells["username"].Value.ToString();
                tb_pass.Text = r.Cells["password"].Value.ToString().Trim();
                cb_type.Text = r.Cells["type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Select account first!");
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if(cb_type.Text == "")
            {
                cb_type.Text = "student";
                rb_Male.Checked = true;
            }
            
        }
    }
}
