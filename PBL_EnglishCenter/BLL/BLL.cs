using PBL_EnglishCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_EnglishCenter.BLL
{
    public class BLL
    {
        private static BLL _Instance;
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL();
                return _Instance;
            }
            private set { }
        }
        private BLL(){} 
        // get all (Loc)  
        public List<location> getListAllLocation()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.locations.ToList();
        }
        public List<schedule> getListAllSchedule()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.schedules.ToList();
        }
        public List<course> getListAllCourse()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.courses.ToList();
        }
        public List<announcement> getListAllAnnouncement()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.announcements.ToList();
        }
        public List<document> getListAllDocument()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.documents.ToList();
        }
        public List<attendance> getListAllAttendance()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.attendances.ToList();
        }
        public List<course_member> getListAllCourseMember()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.course_member.ToList();
        }
        public List<exam> getListAllExam()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exams.ToList();
        }
        public List<exam_details> getListAllExamDetails()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exam_details.ToList();
        }
        public List<user> getListAllUser()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.users.ToList();
        }
        public List<account> getListAllStudentAccount()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Where(p => p.type.Equals("student")).ToList();
        }
        public List<user> getListAllStudent(string searchName)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Where(p => p.type.Equals("student") && p.user.fullname.Contains(searchName)).Select(p => p.user).ToList();
        }
        public List<account> getListAllAccount()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.ToList();
        }
        public List<teacher_info> getListAllTeacherInfo()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.teacher_info.ToList();
        }
        public List<student_info> getListAllStudentInfo()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.student_info.ToList();
        }
        
        // get by conditions
        public location getLocationById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.locations.Find(Id);
        }
        public schedule getScheduleById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.schedules.Find(Id);
        }
        public announcement getAnnouncementById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.announcements.Find(Id);
        }
        public document getDocumentById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.documents.Find(Id);
        }
        public attendance getAttendanceById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.attendances.Find(Id);
        }
        public course_member getCourseMemberById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.course_member.Find(Id);
        }
        public exam getExamById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exams.Find(Id);
        }
        public exam_details getExamDetailsById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exam_details.Find(Id);
        }
        public user getUserById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.users.Find(Id);
        }
        public account getAccountById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Find(Id);
        }
        // teacher_info and user_info (Loc)
        public teacher_info getTeacherInfoById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.teacher_info.Find(Id);
        }
        public teacher_info getTeacherInfoByUserId(int userId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.teacher_info.Where(p => p.user_id == userId).FirstOrDefault();
        }
        public student_info getStudentInfoById(int Id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.student_info.Find(Id);
        }
        public student_info getStudentInfoByUserId(int userId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.student_info.Where(p => p.user_id == userId).FirstOrDefault();
        }
        public List<schedule> getListScheduleByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.schedules.Where(p => p.course_id == courseId).ToList();
        }
        public List<announcement> getListAnnouncementByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.announcements.Where(p => p.course_id == courseId).ToList();
        }
        public List<document> getListDocumentByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.documents.Where(p => p.course_id == courseId).ToList();
        }
        public List<attendance> getListAttendanceByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.attendances.Where(p => p.course_id == courseId).ToList();
        }
        public attendance getAttendanceByCourseIdAndStudentId(int courseId, int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.attendances.Where(p => p.course_id == courseId && p.student_id == studentId).FirstOrDefault();
        }
        public course_member getCourseMemberByCourseIdAndStudentId(int courseId, int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.course_member.Where(p => p.course_id == courseId && p.student_id == studentId).FirstOrDefault();
        }
        public List<exam> getListExamByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exams.Where(p => p.course_id == courseId).ToList();
        }
        public exam_details getExamDetailsByExamIdAndStudentId(int examId, int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.exam_details.Where(p => p.exam_id == examId && p.student_id == studentId).FirstOrDefault();
        }
        public List<user> getListStudentByCourseId(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            List<user> students = new List<user>();
            List<course_member> list1 = db.course_member.Where(p => p.course_id == courseId).ToList();
            foreach(course_member i in list1)
            {
                students.Add(db.users.Find(i.student_id));
            }
            return students;
        }
        public List<account> getListAllAdminAccount()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Where(p => p.type.Equals("admin")).ToList();
        }

        // announcement Student (Loc)
        public List<course_member> getListCourseMemberByStudentId(int studentId) // seek in course_member
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.course_member.Where(p => p.student_id == studentId).ToList(); 
        }
        public List<int> getListCourseIdByStudentId(int studentId) 
        {
            List<int> res = new List<int>();
            foreach(course_member i in getListCourseMemberByStudentId(studentId))
            {
                res.Add((int)i.course_id);
            }
            return res;
        }
        public List<announcement> getListAnnouncementByStudentId(int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            List<announcement> res = new List<announcement>();
            foreach (int i in getListCourseIdByStudentId(studentId))
            {
                res.Add(db.announcements.Where(p => p.course_id == i).FirstOrDefault());
            }
            return res;
        }
        //
        public List<course> getListCourseByStudentId(int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            List<course> res = new List<course>();
            foreach (int i in getListCourseIdByStudentId(studentId))
            {
                res.Add(db.courses.Where(p => p.id == i).FirstOrDefault());
            }
            return res;
        }
        // announcement teacher (Loc)
        public List<course> getListCourseByTeacherId(int teacherId) // seek in course
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.courses.Where(p => p.teacher_id == teacherId).ToList();
        }
        public List<int> getListCourseIdByTeacherId(int teacherId)
        {
            List<int> res = new List<int>();
            foreach (course i in getListCourseByTeacherId(teacherId))
            {
                res.Add((int)i.id);
            }
            return res;
        }
        public List<announcement> getListAnnouncementByTeacherId(int studentId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            List<announcement> res = new List<announcement>();
            foreach (int i in getListCourseIdByTeacherId(studentId))
            {
                res.Add(db.announcements.Where(p => p.course_id == i).FirstOrDefault());
            }
            return res;
        }
        // functions to check condition (Loc)
        public account checkLogin(string username, string password)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Where(p => p.username.Equals(username) && p.password.Equals(password)).FirstOrDefault();
        }
        public bool checkConflictSchedule(int locationId, string time)
        {
            return true;
        }

        //cac ham moi cho accountManage (Hai update)
        public void addUser(user tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            db.users.Add(tmp);
            db.SaveChanges();
        }
        public void addAccount(account tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            db.accounts.Add(tmp);
            db.SaveChanges();
        }
        public void deleteAccount(int id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            account tmp = db.accounts.Where(p => p.id == id).FirstOrDefault();
            db.accounts.Remove(tmp);
            db.SaveChanges();
        }
        public void updateUser(user tmp1)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            db.Entry(tmp1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void updateAccount(account tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            db.Entry(tmp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
        public DataTable getAllAccount(string text)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "id",DataType = typeof(int)},
                new DataColumn{ColumnName = "username",DataType = typeof(string)},
                new DataColumn{ColumnName = "password",DataType = typeof(string)},
                new DataColumn{ColumnName = "type",DataType = typeof(string)},
                new DataColumn{ColumnName = "fullname",DataType = typeof(string)},
                new DataColumn{ColumnName = "user_id",DataType = typeof(string)}
            });
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            foreach (account i in getListAllAccount())
            {
                if (i.username.Contains(text))
                {
                    data.Rows.Add(i.id, i.username, i.password, i.type, i.user.fullname, i.user_id);
                }
            }
            return data;
        }
        public DataTable getListAllTypeAccount(string type)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "id",DataType = typeof(int)},
                new DataColumn{ColumnName = "username",DataType = typeof(string)},
                new DataColumn{ColumnName = "password",DataType = typeof(string)},
                new DataColumn{ColumnName = "type",DataType = typeof(string)},
                new DataColumn{ColumnName = "fullname",DataType = typeof(string)},
                new DataColumn{ColumnName = "user_id",DataType = typeof(string)}
            });
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            foreach (account i in db.accounts.Where(p => p.type.Equals(type)).ToList())
            {
                data.Rows.Add(i.id, i.username, i.password, i.type, i.user.fullname, i.user_id);
            }
            return data;
        }
        public DataTable getSearchAccount(string type, string text)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "id",DataType = typeof(int)},
                new DataColumn{ColumnName = "username",DataType = typeof(string)},
                new DataColumn{ColumnName = "password",DataType = typeof(string)},
                new DataColumn{ColumnName = "type",DataType = typeof(string)},
                new DataColumn{ColumnName = "fullname",DataType = typeof(string)},
                new DataColumn{ColumnName = "user_id",DataType = typeof(string)}
            });
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            foreach (account i in db.accounts.Where(p => p.type.Equals(type)).ToList())
            {
                if (i.username.Contains(text))
                {
                    data.Rows.Add(i.id, i.username, i.password, i.type, i.user.fullname, i.user_id);
                }
            }
            return data;
        }
        // functions for Teacher (Loc update)
        public List<user> getListAllUserIsTeacher()
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return (db.accounts.Where(p => p.type.Equals("teacher"))).Select(p => p.user).ToList();
        }
        public List<CBBItem> getListCBBAllTeacher()
        {
            List<CBBItem> res = new List<CBBItem>();
            foreach(user i in getListAllUserIsTeacher())
            {
                res.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.fullname
                });
            }
            return res;
        }
        public List<course> getListCourseByStatusAndName(string status, string name)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            if(status.Equals("all"))
            {
                return db.courses.Where(p => p.name.Contains(name)).ToList();
            }
            return db.courses.Where(p => p.status.Equals(status) && p.name.Contains(name)).ToList();
        }
        public List<CBBItem> getListCBBAllLocation()
        {
            List<CBBItem> res = new List<CBBItem>();
            foreach (location i in getListAllLocation())
            {
                res.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.name + ", " + i.description
                });
            }
            return res;
        }
        public void addCourse(course tempAddCourse, schedule sche1, schedule sche2)
        {
            using (pbl3_english_centerEntities db = new pbl3_english_centerEntities())
            {
                db.courses.Add(tempAddCourse);
                sche1.course_id = tempAddCourse.id;
                sche2.course_id = tempAddCourse.id;
                db.schedules.Add(sche1);
                db.schedules.Add(sche2);
                db.SaveChanges();
            }
        }
        public course getCourseByCourseID(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.courses.Find(courseId);
        }
        public void editCourse(int id, string name, int cost, int limit, string description, string status, DateTime time_begin, DateTime time_end, int teacher_id, int location_id)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            course tempCourse = db.courses.Where(p => p.id == id).FirstOrDefault();
            tempCourse.name = name;
            tempCourse.cost = cost;
            tempCourse.limit = limit;
            tempCourse.description = description;
            tempCourse.status = status;
            tempCourse.time_begin = time_begin;
            tempCourse.time_end = time_end;
            tempCourse.teacher_id = teacher_id;
            tempCourse.location_id = location_id;
            db.SaveChanges();
        }
        public void editCourse(course tempCourse, schedule sche1, schedule sche2)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            course curCourse = db.courses.Where(p => p.id == tempCourse.id).FirstOrDefault();
            curCourse.name = tempCourse.name;
            curCourse.cost = tempCourse.cost;
            curCourse.limit = tempCourse.limit;
            curCourse.description = tempCourse.description;
            curCourse.status = tempCourse.status;
            curCourse.time_begin = tempCourse.time_begin;
            curCourse.time_end = tempCourse.time_end;
            curCourse.teacher_id = tempCourse.teacher_id;
            curCourse.location_id = tempCourse.location_id;
            //
            schedule curSche1 = db.schedules.Where(p => p.id == sche1.id).FirstOrDefault();
            curSche1.time = sche1.time;
            schedule curSche2 = db.schedules.Where(p => p.id == sche2.id).FirstOrDefault();
            curSche2.time = sche2.time;
            db.SaveChanges();
        }
        // Save profile Long code
        public void saveUser(user tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            user tempUser = db.users.Where(p => p.id == tmp.id).FirstOrDefault();
            tempUser.fullname = tmp.fullname;
            tempUser.gender = tmp.gender;
            tempUser.phone = tmp.phone;
            tempUser.gmail = tmp.gmail;
            db.SaveChanges();
        }
        public void saveAccount(account tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            account tempAccount = db.accounts.Where(p => p.id == tmp.id).FirstOrDefault();
            tempAccount.password = tmp.password;
            db.SaveChanges();
        }
        public void saveDegree(teacher_info tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            teacher_info tempTeacherInfo = db.teacher_info.Where(p => p.user_id == tmp.id).FirstOrDefault();
            tempTeacherInfo.degree = tmp.degree;
            db.SaveChanges();
        }
        public void saveParentPhone(student_info tmp)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            student_info tempStudentInfo = db.student_info.Where(p => p.user_id == tmp.id).FirstOrDefault();
            tempStudentInfo.parent_phone = tmp.parent_phone;
            db.SaveChanges();
        }
        // functions to custom dataGridView (Loc)
        public DataTable customDGVAnnInViewCourseDetails(int courseId) // student & teacher
        {
            DataTable data = new DataTable();
            List<announcement> temp = getListAnnouncementByCourseId(courseId);
            temp.Reverse();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Title", typeof(string)),
                new DataColumn("Description", typeof(string))
            });
            foreach (announcement i in temp)
            {
                data.Rows.Add(i.name, i.description);
            }
            return data;
        }
        public DataTable customDGVExamInViewCourseDetails(int courseId, int stuId) // student
        {
            DataTable data = new DataTable();
            List<exam> temp = getListExamByCourseId(courseId);
            temp.Reverse();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Name", typeof(string)),
                new DataColumn("Link", typeof(string)),
                new DataColumn("Grade", typeof(string)),
                new DataColumn("Feedback", typeof(string))
            });
            foreach (exam i in temp)
            {
                string grade = "";
                string feedback = "";
                if (getExamDetailsByExamIdAndStudentId(i.id, stuId) != null)
                {
                    grade = getExamDetailsByExamIdAndStudentId(i.id, stuId).grade.ToString();
                    feedback = getExamDetailsByExamIdAndStudentId(i.id, stuId).feedback.ToString();
                }
                data.Rows.Add(i.name, i.description, grade, feedback);
            }
            return data;
        }
        public DataTable customDGVDocInViewCourseDetails(int courseId) // student
        {
            DataTable data = new DataTable();
            List<document> temp = getListDocumentByCourseId(courseId);
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string))
            });
            foreach (document i in temp)
            {
                data.Rows.Add(i.name, i.description);
            }
            return data;
        }
        public DataTable customDGVAnnInMainFormAdm() // admin
        {
            DataTable data = new DataTable();
            List<announcement> ann = new List<announcement>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Course Name", typeof(string)),
                new DataColumn("Title", typeof(string)),
                new DataColumn("Description", typeof(string))
            });
            foreach (announcement i in getListAllAnnouncement())
            {
                data.Rows.Add( i.course.name, i.name, i.description);
            }
            return data;
        }
        public DataTable customDGVAnnInMainFormStu(int stuId) // student
        {
            DataTable data = new DataTable();
            //List<announcement> ann = new List<announcement>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Course Name", typeof(string)),
                new DataColumn("Title", typeof(string)),
                new DataColumn("Description", typeof(string))
            });
            foreach (int i in getListCourseIdByStudentId(stuId))
            {
                foreach (announcement j in getListAnnouncementByCourseId(i))
                {
                    data.Rows.Add(getCourseByCourseID(i).name, j.name, j.description);
                }
            }
            return data;
        }
        public DataTable customDGVAnnInMainFormTea(int teaId) // teacher
        {
            DataTable data = new DataTable();
            List<announcement> ann = new List<announcement>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Course Name", typeof(string)),
                new DataColumn("Title", typeof(string)),
                new DataColumn("Description", typeof(string))
            });
            foreach (int i in getListCourseIdByTeacherId(teaId))
            {
                foreach (announcement j in getListAnnouncementByCourseId(i))
                {
                    data.Rows.Add(getCourseByCourseID(i).name, j.name, j.description);
                }
            }
            return data;
        }
        public DataTable customDGVCourseViewStu(int studentId) // student
        {
            DataTable data = new DataTable();
            List<course> ann = new List<course>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Number of places", typeof(string)),
                new DataColumn("Teacher", typeof(string)),
                new DataColumn("Location", typeof(string)),
                new DataColumn("Status", typeof(string)),
                new DataColumn("Schedule", typeof(string)),
                new DataColumn("Cost", typeof(string))
            });
            foreach (course i in getListCourseByStudentId(studentId))
            {
                string sche = "";
                foreach(schedule v in getListScheduleByCourseId(i.id))
                {
                    sche += (v.time).ToString() + ". ";
                }
                data.Rows.Add(
                    (i.id).ToString(),
                    i.name, 
                    i.description, 
                    (i.limit).ToString(), 
                    getUserById((int)i.teacher_id).fullname, 
                    getLocationById((int)i.location_id).name + ", " + getLocationById((int)i.location_id).description,
                    i.status,
                    sche,
                    (i.cost).ToString()
                );
            }
            return data;
        }
        public DataTable customDGVCourseViewAdm() // admin
        {
            DataTable data = new DataTable();
            List<course> ann = new List<course>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                //new DataColumn("Description", typeof(string)),
                //new DataColumn("Number of places", typeof(string)),
                new DataColumn("Teacher", typeof(string)),
                //new DataColumn("Location", typeof(string)),
                new DataColumn("Status", typeof(string)),
                new DataColumn("Schedule", typeof(string)),
                //new DataColumn("Cost", typeof(string))
            });
            foreach (course i in getListAllCourse())
            {
                string sche = "";
                foreach (schedule v in getListScheduleByCourseId(i.id))
                {
                    sche += (v.time).ToString() + ". ";
                }
                data.Rows.Add(
                    (i.id).ToString(),
                    i.name,
                    //i.description,
                    //(i.limit).ToString(),
                    getUserById((int)i.teacher_id).fullname,
                    //getLocationById((int)i.location_id).name + ", " + getLocationById((int)i.location_id).description,
                    i.status,
                    sche
                    //(i.cost).ToString()
                );
            }
            return data;
        }
        public DataTable customDGVCourseViewTea(int teacherId) // teacher
        {
            DataTable data = new DataTable();
            List<course> ann = new List<course>();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Number of places", typeof(string)),
                new DataColumn("Teacher", typeof(string)),
                new DataColumn("Location", typeof(string)),
                new DataColumn("Status", typeof(string)),
                new DataColumn("Schedule", typeof(string)),
                new DataColumn("Cost", typeof(string))
            });
            foreach (course i in getListCourseByTeacherId(teacherId))
            {
                string sche = "";
                foreach (schedule v in getListScheduleByCourseId(i.id))
                {
                    sche += (v.time).ToString() + ". ";
                }
                data.Rows.Add(
                    (i.id).ToString(),
                    i.name,
                    i.description,
                    (i.limit).ToString(),
                    getUserById((int)i.teacher_id).fullname,
                    getLocationById((int)i.location_id).name + ", " + getLocationById((int)i.location_id).description,
                    i.status,
                    sche,
                    (i.cost).ToString()
                );
            }
            return data;
        }
        public DataTable customDGVViewParticipants(int courseId, string searchName) // admin & teacher
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Gmail", typeof(string))
            });
            foreach (user i in getListStudentByCourseId(courseId))
            {
                if(i.fullname.Contains(searchName))
                {
                    data.Rows.Add(
                    (i.id).ToString(),
                    i.fullname,
                    i.gender,
                    i.phone,
                    i.gmail
                    );
                }
            }
            return data;
        }
        public DataTable customDGVSearchStudent(string searchName) // admin & teacher
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Gmail", typeof(string))
            });
            foreach (user i in getListAllStudent(searchName))
            {
                data.Rows.Add(
                (i.id).ToString(),
                i.fullname,
                i.gender,
                i.phone,
                i.gmail
                );
            }
            return data;
        }
        public void addAnnouncement(announcement annToAdd)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            db.announcements.Add(annToAdd);
            db.SaveChanges();
        }
        // functions for course Management
        public void removeCourseMember(int courseId, int stuId) 
        {
            try
            {
                pbl3_english_centerEntities db = new pbl3_english_centerEntities();
                course_member tempCourseMember = db.course_member.Where(p => p.course_id == courseId && p.student_id == stuId).FirstOrDefault();
                db.course_member.Remove(tempCourseMember);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Remove failed. The student hasn't been registered to course yet.");
            }
        }
        public void addStudentToCourse(int courseId, int stuId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            course_member tempCourseMember = new course_member
            {
                course_id = courseId,
                student_id = stuId
            };
            db.course_member.Add(tempCourseMember);
            db.SaveChanges();
        }
        public bool checkCourseToDelete(int courseId)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            int numOfRecord = (db.course_member.Where(p => p.course_id == courseId)).Count();
            if(numOfRecord == 0)
            {
                return true;
            }
            return false;
        }
        public bool deleteCourse(int courseId)
        {
            if(checkCourseToDelete(courseId)) 
            {
                pbl3_english_centerEntities db = new pbl3_english_centerEntities();
                course tempCourse = db.courses.Find(courseId);
                db.courses.Remove(tempCourse);
                db.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
