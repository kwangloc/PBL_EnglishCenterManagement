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
            setCBBStatus();
            setCBBSearchByStatus();
            setCBBTeacher();
            setCBBLocation();
            setGUI(); // set dgv
        }
        private void setGUI()
        {
            // set hello + full name
            lb_fullname.Text = "Hello, " + (BLL.BLL.Instance.getUserById((int)currentAccount.user_id)).fullname;
            // set manage course dgv
            dgv_courseadmin.DataSource = BLL.BLL.Instance.getListAllCourse().ToList();

        }
        private void setCBBStatus()
        {
            cbb_status.Items.Add(new CBBItem { Value = 1, Text = "recruitment" });
            cbb_status.Items.Add(new CBBItem { Value = 2, Text = "in process" });
            cbb_status.Items.Add(new CBBItem { Value = 3, Text = "finish" });
        }
        private void setCBBSearchByStatus()
        {
            cbb_searchStatus.Items.Add(new CBBItem { Value = 0, Text = "all" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 1, Text = "recruitment" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 2, Text = "in process" });
            cbb_searchStatus.Items.Add(new CBBItem { Value = 3, Text = "finish" });
        }
        private void setCBBTeacher()
        {
            foreach (CBBItem i in BLL.BLL.Instance.getListCBBAllTeacher())
            {
                cbb_teacher.Items.Add(i);
            }
        }
        private void setCBBLocation()
        {
            foreach (CBBItem i in BLL.BLL.Instance.getListCBBAllLocation())
            {
                cbb_location.Items.Add(i);
            }
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            if (dgv_courseadmin.SelectedRows.Count == 1)
            {
                int courseId = Convert.ToInt32(dgv_courseadmin.SelectedRows[0].Cells["id"].Value);
                course tempCourse = BLL.BLL.Instance.getCourseByCourseID(courseId);
                tb_id.Text = tempCourse.id.ToString();
                tb_name.Text = tempCourse.name.ToString();
                tb_cost.Text = tempCourse.cost.ToString();
                tb_limit.Text = tempCourse.limit.ToString();
                rtb_des.Text = tempCourse.description;
                cbb_status.Text = tempCourse.status.ToString();
                dtp_timebegin.Value = Convert.ToDateTime(tempCourse.time_begin);
                dtp_timeend.Value = Convert.ToDateTime(tempCourse.time_end);
                foreach(CBBItem i in cbb_teacher.Items)
                {
                    if(i.Value == tempCourse.teacher_id)
                    {
                        cbb_teacher.SelectedItem = i;
                    }
                }
                foreach (CBBItem i in cbb_location.Items)
                {
                    if (i.Value == tempCourse.location_id)
                    {
                        cbb_location.SelectedItem = i;
                    }
                }
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
        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int idCourseToEdit = Convert.ToInt32(tb_id.Text);
                string name = tb_name.Text;
                int cost = Convert.ToInt32(tb_cost.Text);
                int limit = Convert.ToInt32(tb_limit.Text);
                string description = rtb_des.Text;
                string status = cbb_status.SelectedItem.ToString();
                DateTime time_begin = dtp_timebegin.Value;
                DateTime time_end = dtp_timeend.Value;
                int teacher_id = ((CBBItem)(cbb_teacher.SelectedItem)).Value;
                int location_id = ((CBBItem)(cbb_location.SelectedItem)).Value;
                BLL.BLL.Instance.editCourse(idCourseToEdit, name, cost, limit, description, status, time_begin, time_end, teacher_id, location_id);  
            }
            catch
            {
                MessageBox.Show("Fill all required info.");
            }
            setGUI();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            rtb_des.Text = "";
            tb_cost.Text = "";
            tb_limit.Text = "";
            dtp_timebegin.Value = new DateTime(2023, 1, 1);
            dtp_timeend.Value = new DateTime(2023, 2, 1);
            cbb_location.SelectedIndex = 0;
            cbb_status.SelectedIndex = 0;
            cbb_teacher.SelectedIndex = 0;
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                course tempAddCourse = new course
                {
                    name = tb_name.Text.Trim(),
                    description = rtb_des.Text.Trim(),
                    cost = Convert.ToInt32(tb_cost.Text.Trim()),
                    limit = Convert.ToInt32(tb_limit.Text.Trim()),
                    time_begin = Convert.ToDateTime(dtp_timebegin.Value),
                    time_end = Convert.ToDateTime(dtp_timeend.Value),
                    teacher_id = ((CBBItem)cbb_teacher.SelectedItem).Value,
                    location_id = ((CBBItem)cbb_location.SelectedItem).Value,
                    status = cbb_status.SelectedItem.ToString()
                };
                BLL.BLL.Instance.addCourse(tempAddCourse);
            }
            catch
            {
                MessageBox.Show("Fill all required info");
            }
            setGUI();
        }
    }
}
