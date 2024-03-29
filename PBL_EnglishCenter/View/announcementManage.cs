﻿using System;
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
    public partial class announcementManage : Form
    {
        private int courseId;
        private int annId;
        public announcementManage(int courseId, int annId = -1)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.annId = annId;
            setGUI();
        }
        private void setGUI()
        {
            tb_courseName.Text = BLL.BLL.Instance.getCourseByCourseID(courseId).name;
            tb_courseName.Enabled = false;
            if(annId != -1)
            {
                announcement tempAnn = BLL.BLL.Instance.getAnnouncementById(annId);
                tb_title.Text = tempAnn.name;
                rtb_des.Text = tempAnn.description;
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
                announcement tempAnn = new announcement
                {
                    id = annId,
                    name = tb_title.Text,
                    description = rtb_des.Text,
                    course_id = courseId
                };
                BLL.BLL.Instance.addEditAnnouncement(tempAnn);
            }
            catch
            {
                MessageBox.Show("Fill all required information");
            }
            this.Dispose();
        }
    }
}
