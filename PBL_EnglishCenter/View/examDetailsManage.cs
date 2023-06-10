using System;
using System.CodeDom.Compiler;
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
    public partial class examDetailsManage : Form
    {
        private int examId;
        public examDetailsManage(int examId)
        {
            InitializeComponent();
            this.examId = examId;
            setGUI();
        }
        private void setGUI()
        {
            exam tempExam = BLL.BLL.Instance.getExamById(examId);
            tb_examName.Text = tempExam.name;
            rtb_examDes.Text = tempExam.description;
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVExamDetails(examId);
            dataGridView1.Columns["examDetails ID"].Visible = false;
            tb_stuName.Enabled = false;
            tb_stuId.Enabled = false;;
        }
        private void bt_view_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                tb_stuId.Text = dataGridView1.SelectedRows[0].Cells["Student ID"].Value.ToString();
                tb_stuName.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                tb_grade.Text = dataGridView1.SelectedRows[0].Cells["Grade"].Value.ToString();
                rtb_feedback.Text = dataGridView1.SelectedRows[0].Cells["Feedback"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Choose only 1 student!");
            }
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                exam_details tempExamDetails = new exam_details
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["examDetails ID"].Value),
                    grade = Convert.ToDouble(tb_grade.Text),
                    feedback = rtb_feedback.Text,
                    exam_id = examId,
                    student_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Student ID"].Value)
                };
                BLL.BLL.Instance.editExamDetails(tempExamDetails);
                MessageBox.Show("Saved successfully!");
                setGUI();
            }
            catch
            {
                MessageBox.Show("Save failed. Try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            int edid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["examDetails ID"].Value);
            exam_details temp = db.exam_details.Find(edid);
            if(temp.grade == null)
            {
                MessageBox.Show("Null");
            }
            else
            {
                MessageBox.Show("Not Null");
            }
        }
    }
}
