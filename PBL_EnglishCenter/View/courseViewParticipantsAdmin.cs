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
    public partial class courseViewParticipantsAdmin : Form
    {
        private int currentCourseID;
        public courseViewParticipantsAdmin(int courseID)
        {
            InitializeComponent();
            this.currentCourseID = courseID;
            setGUI();

        }
        private void setGUI()
        {
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVViewParticipants(currentCourseID, "");
            lb_quantity.Text = "This list has " + BLL.BLL.Instance.customDGVViewParticipants(currentCourseID, "").Rows.Count.ToString() + " students.";
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL.Instance.customDGVViewParticipants(currentCourseID, tb_search.Text.ToString().Trim());
            lb_quantity.Text = "This list has " + BLL.BLL.Instance.customDGVViewParticipants(currentCourseID, tb_search.Text).Rows.Count.ToString() + " students.";

        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int stuId = Convert.ToInt32(i.Cells["ID"].Value);
                    BLL.BLL.Instance.removeCourseMember(currentCourseID, stuId);
                }
                //MessageBox.Show((dataGridView1.SelectedRows[0].Cells["ID"].Value).ToString() + currentCourseID.ToString());
            }
            setGUI();
        }
        private void bt_searchToAdd_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL.BLL.Instance.customDGVSearchStudent(tb_searchToAdd.Text);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int stuId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);
                BLL.BLL.Instance.addStudentToCourse(currentCourseID, stuId);
            }
            else
            {
                MessageBox.Show("Add only 1 student at a time!");
            }
            setGUI();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
