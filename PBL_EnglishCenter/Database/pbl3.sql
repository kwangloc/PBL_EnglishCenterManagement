CREATE DATABASE pbl3_english_center;
GO

USE pbl3_english_center;
GO

CREATE TABLE course (
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(100) ,
    description nvarchar(100),
    cost int,
	limit int,
	time_begin date,
	time_end date,
	teacher_id int,
	location_id int,
	status nvarchar(100)
);

CREATE TABLE document (
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(100) ,
    description nvarchar(200),
	course_id int
);

CREATE TABLE announcement (
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(100),
    description nvarchar(100),
	course_id int
);

CREATE TABLE location (
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(100),
    description nvarchar(200)
);

CREATE TABLE schedule (
    id int IDENTITY(1,1) PRIMARY KEY,
    time nvarchar(50),
	course_id int
);

CREATE TABLE attendance (
    id int IDENTITY(1,1) PRIMARY KEY,
    status nvarchar(100),
	create_at date,
	course_id int,
	student_id int
);

CREATE TABLE course_member (
    id int IDENTITY(1,1) PRIMARY KEY,
	course_id int,
	student_id int
);

CREATE TABLE exam (
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(100),
	description nvarchar(200),
    course_id int,
);

CREATE TABLE exam_details (
    id int IDENTITY(1,1) PRIMARY KEY,
    grade float,
	feedback nvarchar(200),
    exam_id int,
	student_id int
);

CREATE TABLE users (
    id int IDENTITY(1,1) PRIMARY KEY,
	fullname nvarchar(100),
    gender nvarchar(100),
	phone nchar(20),
	gmail nchar(50),
);

CREATE TABLE account (
    id int IDENTITY(1,1) PRIMARY KEY,
	username nchar(20),
    password nchar(20),
	type nchar(20),
	user_id  int,
);

CREATE TABLE teacher_info (
    id int IDENTITY(1,1) PRIMARY KEY,
	degree nvarchar(100),
	user_id  int,
);

CREATE TABLE student_info (
    id int IDENTITY(1,1) PRIMARY KEY,
	parent_phone nchar(100),
	user_id  int,
);

ALTER TABLE course
ADD CONSTRAINT FK_teacherid_in_course
FOREIGN KEY (teacher_id) REFERENCES users(id);

ALTER TABLE course
ADD CONSTRAINT FK_locationid_in_course
FOREIGN KEY (location_id) REFERENCES location(id);

ALTER TABLE document
ADD CONSTRAINT FK_courseid_in_document
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE announcement
ADD CONSTRAINT FK_courseid_in_announcement
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE schedule
ADD CONSTRAINT FK_courseid_in_schedule
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE attendance
ADD CONSTRAINT FK_courseid_in_attendance
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE attendance
ADD CONSTRAINT FK_studentid_in_document
FOREIGN KEY (student_id) REFERENCES users(id);

ALTER TABLE course_member
ADD CONSTRAINT FK_courseid_in_coursemember
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE course_member
ADD CONSTRAINT FK_studentid_in_coursemember
FOREIGN KEY (student_id) REFERENCES users(id);

ALTER TABLE exam
ADD CONSTRAINT FK_courseid_in_exam
FOREIGN KEY (course_id) REFERENCES course(id);

ALTER TABLE exam_details
ADD CONSTRAINT FK_examid_in_examdetails
FOREIGN KEY (exam_id) REFERENCES exam(id);

ALTER TABLE exam_details
ADD CONSTRAINT FK_studentid_in_examdetails
FOREIGN KEY (student_id) REFERENCES users(id);

ALTER TABLE account
ADD CONSTRAINT FK_userid_in_account
FOREIGN KEY (user_id) REFERENCES users(id);

ALTER TABLE teacher_info
ADD CONSTRAINT FK_userid_in_teacherinfo
FOREIGN KEY (user_id) REFERENCES users(id);

ALTER TABLE student_info
ADD CONSTRAINT FK_userid_in_studentinfo
FOREIGN KEY (user_id) REFERENCES users(id);
/* insert users*/
--student
INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trương Quang Lộc', N'Nam', '0987654321', 'quangloc1@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trương Viêt Long', N'Nam', '0912354565', 'vietlong1@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Đoàn Nguyễn Sơn Hải', N'Nam', '0988854321', 'sonhai1@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Hoàng Thị Thúy', N'Nữ', '0187654321', 'hoangthuy2@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Dương Thu Hiền', N'Nữ', '0127654321', 'thuhien9@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Văn An', N'Nam', '0987654321', 'vanan.nguyen@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Lê Thị Bình Minh', N'Nữ', '0912345678', 'binhminh.le@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trần Đình Quang', N'Nam', '0978123456', 'quang.tran@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Phạm Thanh Tâm', N'Nam', '0888888888', 'tam.pham@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Hoàng Thị Hạnh', N'Nữ', '0933333333', 'hanh.hoang@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Vũ Minh Tuấn', N'Nam', '0966666666', 'tuan.vu@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Đỗ Thuỳ Dung', N'Nữ', '0944444444', 'dung.do@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Huy Hoàng', N'Nam', '0922222222', 'hoang.nguyen@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trương Quỳnh Anh', N'Nữ', '0909090909', 'quynhanh.truong@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Lý Thị Minh Trang', N'Nữ', '0969696969', 'minhtrang.ly@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Đặng Văn Đức', N'Nam', '0988888888', 'ducdang@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trần Thị Hằng', N'Nữ', '0977777777', 'hang.tran@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Phạm Đức Thịnh', N'Nam', '0965656565', 'thinh.pham@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Thu Trang', N'Nữ', '0919191919', 'thutrang.nguyen@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Lê Minh Tuấn', N'Nam', '0987878787', 'tuan.le@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Thanh Huyền', N'Nữ', '0127654321', 'thuhien9@gmail.com');
--teacher
INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trần Mạnh Hùng', N'Nam', '0123354321', 'mrmanhhung@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Hoàng Thị Hoa', N'Nam', '0198754321', 'mshoanghoa@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Như Tâm', N'Nữ', '0145654321', 'msnhutam@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Hoàng Long', N'Nam', '0777354321', 'mrhoanglong@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Katharine', N'Nữ', '0122254321', 'mskatharine@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trần Minh Tú', N'Nam', '0918234567', 'mrminhtu@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Dua Lipa', N'Nữ', '0898765432', 'msdualipa@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Vũ Đức Hùng', N'Nam', '0976543210', 'mrhunghungvu@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Ngô Thị Thanh Trúc', N'Nữ', '0932123456', 'mstructhanhngo@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Taylor Swift', N'Nữ', '0918234567', 'mstaylorswift@gmail.com');
-- admin
INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Đàm Mạnh Hưng', N'Nam', '0111111111', 'admanhhung@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Trần Đình Tùng', N'Nam', '0111111112', 'addinhtung@gmail.com');

INSERT INTO users (fullname, gender, phone, gmail)
VALUES (N'Nguyễn Duy Dũng', N'Nam', '0111111113', 'adduydung@gmail.com');
/* insert teacher info*/
INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, UFls', 22);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, UFLs', 23);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English Studies, ULIS', 24);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, USSH', 25);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of Economy, DUE', 26);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, VNUK', 27);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of Business Administration, FTU', 28);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, HNUE', 29);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, HNUE', 30);

INSERT INTO teacher_info(degree, user_id)
VALUES (N'Bachelor of English language, HCMUE', 31);

/* insert student_info */

INSERT INTO student_info(parent_phone, user_id)
VALUES ('0123456789', 1),
       ('0987654321', 2),
       ('0168495732', 3),
       ('0912345678', 4),
       ('0896574231', 5),
       ('0946789123', 6),
       ('0987612345', 7),
       ('0162345678', 8),
       ('0909123456', 9),
       ('0918765432', 10),
       ('0987456123', 11),
       ('0934567890', 12),
       ('0167891234', 13),
       ('0978563412', 14),
       ('0912456789', 15),
       ('0923456789', 16),
       ('0912567341', 17),
       ('0987345612', 18),
       ('0978456213', 19),
       ('0167345921', 20),
       ('0909785634', 21);

/* insert account*/
INSERT INTO account(username, password, type, user_id)
VALUES ('quangloc1', 'password1', 'student', 1),
       ('vietlong1', 'password2', 'student', 2),
       ('sonhai1', 'password3', 'student', 3),
       ('hoangthuy2', 'password4', 'student', 4),
       ('thuhien9', 'password5', 'student', 5),
       ('vanan.nguyen', 'password6', 'student', 6),
       ('binhminh.le', 'password7', 'student', 7),
       ('quang.tran', 'password8', 'student', 8),
       ('tam.pham', 'password9', 'student', 9),
       ('hanh.hoang', 'password10', 'student', 10),
       ('tuan.vu', 'password11', 'student', 11),
       ('dung.do', 'password12', 'student', 12),
       ('hoang.nguyen', 'password13', 'student', 13),
       ('quynhanh.truong', 'password14', 'student', 14),
       ('minhtrang.ly', 'password15', 'student', 15),
       ('ducdang', 'password16', 'student', 16),
       ('hang.tran', 'password17', 'student', 17),
       ('thinh.pham', 'password18', 'student', 18),
       ('thutrang.nguyen', 'password19', 'student', 19),
       ('tuan.le', 'password20', 'student', 20),
       ('thuhien9', 'password21', 'student', 21),
       ('mrmanhhung', 'password22', 'teacher', 22),
       ('mshoanghoa', 'password23', 'teacher', 23),
       ('msnhutam', 'password24', 'teacher', 24),
       ('mrhoanglong', 'password25', 'teacher', 25),
       ('mskatharine', 'password26', 'teacher', 26),
       ('mrminhtu', 'password27', 'teacher', 27),
       ('msdualipa', 'password28', 'teacher', 28),
       ('mrhunghungvu', 'password29', 'teacher', 29),
       ('mstructhanhngo', 'password30', 'teacher', 30),
       ('mstaylorswift', 'password31', 'teacher', 31),
	   ('admanhhung', 'password32', 'admin', 32),
       ('addinhtung', 'password33', 'admin', 33),
       ('adduydung', 'password34', 'admin', 34);

/* insert location */
INSERT INTO location(name, description)
VALUES (N'A101', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'A102', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'A103', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'A201', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'A202', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'A203', N'20 Nguyễn Lương Bằng');

INSERT INTO location(name, description)
VALUES (N'B101', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B102', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B103', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B201', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B202', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B203', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B301', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B302', N'100 Phan Châu Trinh');

INSERT INTO location(name, description)
VALUES (N'B303', N'100 Phan Châu Trinh');

/* insert course*/
INSERT INTO course(name, description, cost, limit, time_begin, time_end, teacher_id, location_id, status)
VALUES (N'Tiếng Anh cơ bản từ con số 0', N'Khóa học dành cho người mới bắt đầu', 1500000, 20, '2023-3-15', '2023-8-15', 22, 1, N'in process');

INSERT INTO course(name, description, cost, limit, time_begin, time_end, teacher_id, location_id, status)
VALUES (N'Luyện thi Ielts band 6.5', N'Khóa học dành cho học viên luyện thi Ielts band 6.5 ', 2500000, 20, '2023-4-1', '2023-7-1', 23, 2, N'in process');

INSERT INTO course(name, description, cost, limit, time_begin, time_end, teacher_id, location_id, status)
VALUES (N'Luyện thi Ielts band 7.5', N'Khóa học dành cho học viên luyện thi Ielts band 7.5 ', 2500000, 20, '2023-4-1', '2023-7-1', 24, 2, N'in process');

/* insert course_member */
INSERT INTO course_member(course_id, student_id)
VALUES (1, 1), 
       (1, 2),
	   (1, 3),
       (1, 4),
       (1, 5),
       (1, 6),
       (1, 7),
	   (1, 8),
	   (1, 9),
	   (1, 10),
	   (1, 11),
	   (1, 12),
	   (1, 13),
	   (1, 14),
	   (1, 15),
	   (1, 16),
	   (1, 17),
	   (1, 18),
	   (1, 19),
	   (1, 20);
/* insert schedule */

INSERT INTO schedule(time, course_id)
VALUES (N'thứ 5, 6pm-9pm', 1);

INSERT INTO schedule(time, course_id)
VALUES (N'chủ nhật, 8am-11am', 1);

INSERT INTO schedule(time, course_id)
VALUES (N'thứ 2, 2pm-5pm', 2);

INSERT INTO schedule(time, course_id)
VALUES (N'thứ 6, 6pm-9pm', 2);

/* insert document */
INSERT INTO document(name, description, course_id)
VALUES (N'Giáo trình tiếng Anh cơ bản', N'mshoagiaotiep.com/tron-bo-giao-trinh-tieng-anh-cho-nguoi-mat-goc-full-pdf-nd500022.html', 1);

INSERT INTO document(name, description, course_id)
VALUES (N'Bài tập tiếng Anh cơ bản', N'langgo.edu.vn/download-tong-hop-tai-lieu-tieng-anh-co-ban-cho-nguoi-mat-goc-4-ky-nang', 1);

/* insert exam */
INSERT INTO exam(name, description, course_id)
VALUES (N'Exam 1', N'docs.google.com/document/bai_exam_lan_1', 1);

INSERT INTO exam(name, description, course_id)
VALUES (N'Exam 2', N'docs.google.com/document/bai_exam_lan_2', 1);

/* insert exam_details */
INSERT INTO exam_details(grade, feedback, exam_id, student_id)
VALUES (8.1, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 1),
       (8.3, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 2),
       (7.9, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 3),
       (9.5, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 4),
       (8.7, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 5),
       (7.2, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 6),
       (9.8, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 7),
       (7.6, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 8),
       (9.2, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 9),
       (6.8, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 10),
       (8.9, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 11),
       (7.4, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 12),
       (9.6, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 13),
       (7.8, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 14),
	   (9.2, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 15),
       (6.8, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 16),
       (8.9, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 17),
       (7.4, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 18),
       (9.6, N'Nắm chưa rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 19),
       (7.8, N'Nắm rõ kĩ năng đánh trọng âm, cần cải thiện kĩ năng chọn mạo từ', 1, 20);

/* insert attendance */
INSERT INTO attendance(status, create_at, course_id, student_id)
VALUES (N'Vắng', '2023-4-20', 1, 3);

INSERT INTO attendance(status, create_at, course_id, student_id)
VALUES (N'Vắng', '2023-4-20', 1, 13);

INSERT INTO attendance(status, create_at, course_id, student_id)
VALUES (N'Vắng', '2023-4-27', 1, 22);

INSERT INTO attendance(status, create_at, course_id, student_id)
VALUES (N'Vắng', '2023-4-27', 1, 4);

/*insert announcement */
INSERT INTO announcement(name, description, course_id)
VALUES (N'Thông báo số 1: Ngày 13/4 sẽ có bài test tại lớp', N'Các bạn chú ý mang bút chì và đi học đầy đủ để làm bài test', 1);

INSERT INTO announcement(name, description, course_id)
VALUES (N'Thông báo số 1: Ngày 17/4 chữa listening', N'Chữa listening của test 1', 2);


