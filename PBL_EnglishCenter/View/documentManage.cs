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
    public partial class documentManage : Form
    {
        private int courseId;
        private int docId;
        public documentManage(int courseId, int docId = -1)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.docId = docId;
            setGUI();
        }
        private void setGUI()
        {
            tb_courseName.Text = BLL.BLL.Instance.getCourseByCourseID(courseId).name;
            tb_courseName.Enabled = false;
            if (docId != -1)
            {
                document tempDoc = BLL.BLL.Instance.getDocumentById(docId);
                tb_title.Text = tempDoc.name;
                rtb_des.Text = tempDoc.description;
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
                document tempDoc = new document
                {
                    id = docId,
                    name = tb_title.Text,
                    description = rtb_des.Text,
                    course_id = courseId
                };
                BLL.BLL.Instance.addEditDoc(tempDoc);
            }
            catch
            {
                MessageBox.Show("Fill all required information");
            }
            this.Dispose();
        }
    }
}
