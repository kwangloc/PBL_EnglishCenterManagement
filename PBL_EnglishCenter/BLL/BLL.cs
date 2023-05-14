﻿using PBL_EnglishCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // teacher_info and user_info
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

        // announcement Student
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
        // announcement teacher
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
        // functions to check condition
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
        public void updateUserAndAccount(user tmp1, account tmp2)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            //db.Entry(tmp1).State = System.Data.Entity.EntityState.Modified;
            db.Entry(tmp2).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public List<account> getListAllTypeAccount(string type)
        {
            pbl3_english_centerEntities db = new pbl3_english_centerEntities();
            return db.accounts.Where(p => p.type.Equals(type)).ToList();
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
        public void addCourse(course tempAddCourse)
        {
            using (pbl3_english_centerEntities db = new pbl3_english_centerEntities())
            {
                db.courses.Add(tempAddCourse);
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
        //
    }
}
