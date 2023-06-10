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
    public partial class examManage : Form
    {
        private int courseId;
        private int examId;
        public examManage(int courseId, int examId = -1)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.examId = examId;
            setGUI();
        }
        private void setGUI()
        {
            tb_courseName.Text = BLL.BLL.Instance.getCourseByCourseID(courseId).name;
            tb_courseName.Enabled = false;
            if (examId != -1)
            {
                exam tempExam = BLL.BLL.Instance.getExamById(examId);
                tb_title.Text = tempExam.name;
                rtb_des.Text = tempExam.description;
            }
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                exam tempExam = new exam
                {
                    id = examId,
                    name = tb_title.Text,
                    description = rtb_des.Text,
                    course_id = courseId
                };
                BLL.BLL.Instance.addEditExam(courseId, tempExam);
            }
            catch
            {
                MessageBox.Show("Fill all required information");
            }
            this.Dispose();
        }
    }
}
