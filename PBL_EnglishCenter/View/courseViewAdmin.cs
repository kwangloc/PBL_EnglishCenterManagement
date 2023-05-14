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
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            // set hello + full name
            lb_fullname.Text = "Hello, " + (db.users.Find(currentAccount.user_id)).fullname;
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
            //cbb_teacher.Items.Add(BLL.BLL.Instance.getListCBBAllTeacher());
        }
        private void setCBBLocation()
        {
            foreach (CBBItem i in BLL.BLL.Instance.getListCBBAllLocation())
            {
                cbb_location.Items.Add(i);
            }
            //cbb_teacher.Items.Add(BLL.BLL.Instance.getListCBBAllTeacher());
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            if (dgv_courseadmin.SelectedRows.Count == 1)
            {
                pbl3_english_centerEntities db = new pbl3_english_centerEntities();
                int courseId = Convert.ToInt32(dgv_courseadmin.SelectedRows[0].Cells["id"].Value);
                course tempCourse = db.courses.Find(courseId);
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
                pbl3_english_centerEntities db = new pbl3_english_centerEntities();
                int idCourseToEdit = Convert.ToInt32(tb_id.Text);
                course tempCourse = db.courses.Where(p => p.id == idCourseToEdit).FirstOrDefault();
                //
                tempCourse.name = tb_name.Text;
                tempCourse.cost = Convert.ToInt32(tb_cost.Text);
                tempCourse.limit = Convert.ToInt32(tb_limit.Text);
                tempCourse.description = rtb_des.Text;
                tempCourse.status = cbb_status.SelectedItem.ToString();
                tempCourse.time_begin = dtp_timebegin.Value;
                tempCourse.time_end = dtp_timeend.Value;
                tempCourse.teacher_id = ((CBBItem)(cbb_teacher.SelectedItem)).Value;
                tempCourse.location_id = ((CBBItem)(cbb_location.SelectedItem)).Value;
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Fill all required info.");
            }
            setGUI();
        }
    }
}
