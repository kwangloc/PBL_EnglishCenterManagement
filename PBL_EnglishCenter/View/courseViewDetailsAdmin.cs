using PBL_EnglishCenter.DTO;
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
    public partial class courseViewDetailsAdmin : Form
    {
        public delegate void DelCourseViewDetailsAdmin();
        public DelCourseViewDetailsAdmin DelAdmin2 { get; set; }
        private int currentCourseID;
        private int scheID1;
        private int scheID2;
        public courseViewDetailsAdmin(int courseID = -1)
        {
            InitializeComponent();
            this.currentCourseID = courseID;
            setCBBStatus();
            setCBBTeacher();
            setCBBLocation();
            setCBBSche();
            setGUI();
        }
        private void setCBBStatus()
        {
            cbb_status.Items.Add(new CBBItem { Value = 1, Text = "recruitment" });
            cbb_status.Items.Add(new CBBItem { Value = 2, Text = "in process" });
            cbb_status.Items.Add(new CBBItem { Value = 3, Text = "finish" });
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
        private void setCBBSche()
        {
            List<CBBItem> dayOfWeek = new List<CBBItem>
            {
                new CBBItem(){ Value = 1, Text = "monday" },
                new CBBItem(){ Value = 2, Text = "tuesday" },
                new CBBItem(){ Value = 3, Text = "wednesday" },
                new CBBItem(){ Value = 4, Text = "thursday" },
                new CBBItem(){ Value = 5, Text = "friday" },
                new CBBItem(){ Value = 6, Text = "saturday" },
                new CBBItem(){ Value = 7, Text = "sunday" }
            };
            List<CBBItem> timeDuration = new List<CBBItem>
            {
                new CBBItem(){ Value = 1, Text = "8am-11am" },
                new CBBItem(){ Value = 2, Text = "2pm-5pm" },
                new CBBItem(){ Value = 3, Text = "6pm-9pm" },
            };
            foreach (CBBItem i in dayOfWeek)
            {
                cbb_day1.Items.Add(i);
                cbb_day2.Items.Add(i);
            }
            foreach (CBBItem i in timeDuration)
            {
                cbb_time1.Items.Add(i);
                cbb_time2.Items.Add(i);
            }
        }
        private void setGUI()
        {
            if(currentCourseID != -1)
            {
                course tempCourse = BLL.BLL.Instance.getCourseByCourseID(currentCourseID);
                tb_id.Text = tempCourse.id.ToString();
                tb_name.Text = tempCourse.name.ToString();
                tb_cost.Text = tempCourse.cost.ToString();
                tb_limit.Text = tempCourse.limit.ToString();
                rtb_des.Text = tempCourse.description;
                dtp_timebegin.Value = Convert.ToDateTime(tempCourse.time_begin);
                dtp_timeend.Value = Convert.ToDateTime(tempCourse.time_end);
                foreach (CBBItem i in cbb_status.Items)
                {
                    if (i.Text == tempCourse.status)
                    {
                        cbb_status.SelectedItem = i;
                    }
                }
                foreach (CBBItem i in cbb_teacher.Items)
                {
                    if (i.Value == tempCourse.teacher_id)
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
                foreach(schedule i in BLL.BLL.Instance.getListScheduleByCourseId(currentCourseID))
                {
                    string[] splitSche = i.time.Split(',');
                    if (cbb_day1.SelectedIndex == -1 && cbb_time1.SelectedIndex == -1)
                    {
                        scheID1 = i.id;
                        foreach(CBBItem j in cbb_day1.Items)
                        {
                            if(j.Text.Equals(splitSche[0]))
                            {
                                cbb_day1.SelectedItem = j;
                            }
                        }
                        foreach (CBBItem k in cbb_time1.Items)
                        {
                            if (k.Text.Equals(splitSche[1].Trim()))
                            {
                                cbb_time1.SelectedItem = k;
                            }
                        }
                    }
                    else
                    {
                        scheID2 = i.id;
                        foreach (CBBItem j in cbb_day2.Items)
                        {
                            if (j.Text.Equals(splitSche[0]))
                            {
                                cbb_day2.SelectedItem = j;
                            }
                        }
                        foreach (CBBItem k in cbb_time2.Items)
                        {
                            if (k.Text.Equals(splitSche[1].Trim()))
                            {
                                cbb_time2.SelectedItem = k;
                            }
                        }
                    }
                }
            }
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void bt_listOfPart_Click(object sender, EventArgs e)
        {
            if(currentCourseID != -1)
            {
                courseViewParticipantsAdmin cvpaForm = new courseViewParticipantsAdmin(currentCourseID);
                cvpaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The course hasn't been created!");
            }
        }
        private void bt_ok_Click(object sender, EventArgs e) // add && edit
        {
            try
            {
                course tempCourse = new course
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
                schedule tempSche1 = new schedule
                {
                    time = cbb_day1.SelectedItem.ToString() + ", " + cbb_time1.SelectedItem.ToString(),
                };
                schedule tempSche2 = new schedule
                {
                    time = cbb_day2.SelectedItem.ToString() + ", " + cbb_time2.SelectedItem.ToString(),
                };
                if (tb_id.Text != "") // edit
                {
                    tempCourse.id = Convert.ToInt32(tb_id.Text);
                    tempSche1.id = scheID1;
                    tempSche2.id = scheID2;
                    BLL.BLL.Instance.editCourse(tempCourse, tempSche1, tempSche2);
                }
                else // add
                {
                    BLL.BLL.Instance.addCourse(tempCourse, tempSche1, tempSche2);
                }
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Failed creating! Check the information again!");
            }
            DelAdmin2();
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
    }
}
