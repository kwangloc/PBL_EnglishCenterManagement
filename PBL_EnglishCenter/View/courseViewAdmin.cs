using PBL_EnglishCenter.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            setCBBSearchByStatus();
            setCBBLocation();
            setGUI(); 
        }
        private void setGUI()
        {
            // set hello + full name
            lb_fullname.Text = "Hello, " + (BLL.BLL.Instance.getUserById((int)currentAccount.user_id)).fullname;
            // set manage course dgv
            dgv_courseadmin.DataSource = BLL.BLL.Instance.customDGVCourseViewAdm();
            dgv_courseadmin.Columns["ID"].Visible = false;
        }
        private void setCBBSearchByStatus()
        {
            cbb_searchStatus.Items.Add(new CBBItem { Value = 0, Text = "all" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 1, Text = "recruitment" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 2, Text = "in process" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 3, Text = "finish" });
        }
        private void setCBBLocation()
        {
            foreach (CBBItem i in BLL.BLL.Instance.getListCBBAllLocation())
            {
                cbb_searchLocation.Items.Add(i);
            }
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void bt_viewDetails_Click(object sender, EventArgs e)
        {
            if (dgv_courseadmin.SelectedRows.Count == 1)
            {
                int courseId = Convert.ToInt32(dgv_courseadmin.SelectedRows[0].Cells["ID"].Value);
                courseViewDetailsAdmin cvdaForm = new courseViewDetailsAdmin(courseId);
                cvdaForm.DelAdmin2 += new courseViewDetailsAdmin.DelCourseViewDetailsAdmin(setGUI);
                cvdaForm.ShowDialog();
            }
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_courseadmin.DataSource = BLL.BLL.Instance.getListCourseByStatusAndName(cbb_searchStatus.SelectedItem.ToString().Trim(), tb_searchName.Text.ToString().Trim());
            }
            catch
            {
                MessageBox.Show("Choose type");
            }
        }
        private void bt_create_Click(object sender, EventArgs e)
        {
            courseViewDetailsAdmin cvdaForm = new courseViewDetailsAdmin();
            cvdaForm.DelAdmin2 += new courseViewDetailsAdmin.DelCourseViewDetailsAdmin(setGUI);
            cvdaForm.ShowDialog();
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_courseadmin.SelectedRows.Count == 1)
                {
                    int courseId = Convert.ToInt32(dgv_courseadmin.SelectedRows[0].Cells["ID"].Value);
                    //BLL.BLL.Instance.deleteCourse(courseId);
                    if(BLL.BLL.Instance.deleteCourse(courseId))
                    {
                        MessageBox.Show("Deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Deleted failed. The course must have 0 students to be deleted");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed deleting. Try again!");
            }
            setGUI();
        }
    }
}
