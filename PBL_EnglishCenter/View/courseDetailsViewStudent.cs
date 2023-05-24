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
    public partial class courseDetailsViewStudent : Form
    {
        private account currentAccount;
        private course currentCourse;
        public courseDetailsViewStudent(course currentCourse, account currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            this.currentCourse = currentCourse;
            setGUI();
            setDGV();

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
            if(temp.Count > 1)
            {
                lb_valueSche2.Text = temp[1].time.ToString();
            }
            else
            {
                lb_valueSche2.Hide();
            }
        }
        private void setDGV()
        {
            //dgv_ann.DataSource = BLL.BLL.Instance.getListAnnouncementByCourseId(currentCourse.id);
            dgv_ann.DataSource = BLL.BLL.Instance.customDGVAnnInViewCourseDetails(currentCourse.id);
            //dgv_exam.DataSource = BLL.BLL.Instance.getListExamByCourseId(currentCourse.id);
            dgv_exam.DataSource = BLL.BLL.Instance.customDGVExamInViewCourseDetails(currentCourse.id, (int)currentAccount.user_id);
            //dgv_doc.DataSource = BLL.BLL.Instance.getListDocumentByCourseId(currentCourse.id);
            dgv_doc.DataSource = BLL.BLL.Instance.customDGVDocInViewCourseDetails(currentCourse.id);
        }

        private void bt_viewExamDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
