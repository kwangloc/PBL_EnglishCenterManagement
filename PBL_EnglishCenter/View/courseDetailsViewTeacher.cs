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

    public partial class courseDetailsViewTeacher : Form
    {
        private account currentAccount;
        private course currentCourse;
        public courseDetailsViewTeacher(course currentCourse, account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            this.currentCourse = currentCourse;
            setGUI();
        }
        private void setGUI()
        {
            lb_valueNameCourse.Text = currentCourse.name;
            lb_valueDescription.Text = currentCourse.description;
            lb_valueLimit.Text = currentCourse.limit.ToString();
            lb_valueLocation.Text = BLL.BLL.Instance.getLocationById((int)currentCourse.location_id).name + ", " + BLL.BLL.Instance.getLocationById((int)currentCourse.location_id).description;
            lb_valueStatus.Text = currentCourse.status;
            lb_valueTimeBegin.Text = currentCourse.time_begin.Value.Day.ToString() + "/" + currentCourse.time_begin.Value.Month.ToString() + "/" + currentCourse.time_begin.Value.Year.ToString();
            lb_valueTimeEnd.Text = currentCourse.time_end.Value.Day.ToString() + "/" + currentCourse.time_end.Value.Month.ToString() + "/" + currentCourse.time_end.Value.Year.ToString();
            lb_valueTeacher.Text = (BLL.BLL.Instance.getUserById((int)currentCourse.teacher_id)).fullname;
            List<schedule> temp = BLL.BLL.Instance.getListScheduleByCourseId(currentCourse.id);
            lb_valueSche1.Text = temp[0].time.ToString();
            if (temp.Count > 1)
            {
                lb_valueSche2.Text = temp[1].time.ToString();
            }
            else
            {
                lb_valueSche2.Hide();
            }
        }
        private void bt_ann_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVAnnInViewCourseDetails(currentCourse.id);
            dataGridView1.Columns["ID"].Visible = false;
            // buttons
            bt_editAnn.Visible = true;
            bt_newAnn.Visible = true;
            bt_editExam.Visible = false;
            bt_newExam.Visible = false;
            bt_examRes.Visible = false;
            bt_editDoc.Visible = false;
            bt_newDoc.Visible = false;
        }
        private void bt_exam_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVExamInViewTeacher(currentCourse.id);
            bt_editAnn.Visible = false;
            bt_newAnn.Visible = false;
            bt_editExam.Visible = true;
            bt_newExam.Visible = true;
            bt_examRes.Visible = true;
            bt_editDoc.Visible = false;
            bt_newDoc.Visible = false;
        }
        private void bt_doc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVDocInViewCourseDetails(currentCourse.id);
            bt_editAnn.Visible = false;
            bt_newAnn.Visible = false;
            bt_editExam.Visible = false;
            bt_newExam.Visible = false;
            bt_examRes.Visible = false;
            bt_editDoc.Visible = true;
            bt_newDoc.Visible = true;
        }
        private void courseDetailsViewTeacher_Load(object sender, EventArgs e)
        {
            bt_ann_Click(new object(), new EventArgs());
        }
        private void bt_newAnn_Click(object sender, EventArgs e)
        {
            announcementManage amForm = new announcementManage(currentCourse.id);
            amForm.ShowDialog();
        }
        private void bt_editAnn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                announcementManage amForm = new announcementManage(currentCourse.id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                amForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose an announcement to edit!.");
            }
        }
        private void bt_newDoc_Click(object sender, EventArgs e)
        {
            documentManage dmForm = new documentManage(currentCourse.id);
            dmForm.ShowDialog();
        }

        private void bt_editDoc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                documentManage dmForm = new documentManage(currentCourse.id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                dmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a document to edit!.");
            }
        }
        private void bt_newExam_Click(object sender, EventArgs e)
        {
            examManage emForm = new examManage(currentCourse.id);
            emForm.ShowDialog();
        }
        private void bt_editExam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                examManage emForm = new examManage(currentCourse.id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                emForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose an exam to edit!.");
            }
        }

        private void bt_examRes_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                examDetailsManage edmForm = new examDetailsManage(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                edmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose an exam to results from students!.");
            }
        }
    }
}
