using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
    static class DataAccess
    {

        internal static List<Status> GetStatuses()
        {
            List<Status> st = new List<Status>();
            using (dbEntities ent = new dbEntities())
            {
                var r = (from f in ent.status_tbl
                         select f).ToList<status_tbl>();
                foreach (var item in r)
                {
                    st.Add(new Status
                    {

                        StatusId = item.StatusId,
                        StatusName = item.StatusName
                    });
                }
                return st;
            }
        }


        internal static Users GetUsers(string username, string password)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.user_tbl
                              where i.Username == username && i.Password == password && i.StatusId == 1
                              select i).SingleOrDefault();
                if (result == null)
                {
                    return null;
                }
                return new Users
                {
                    UserId = result.UserId,
                    Username = result.Username,
                    Password = result.Password,
                    StatudId = result.StatusId
                };



            }
        }


        internal static int InsertStudent(Student student)
        {
            using (dbEntities entity = new dbEntities())
            {
                student_tbl student_Tbl = new student_tbl();

                student_Tbl.Name = student.Name;
                student_Tbl.Surname = student.Surname;
                student_Tbl.Gender = student.Gender;
                student_Tbl.Cell = student.Cell;
                student_Tbl.Email = student.Email;
                student_Tbl.PostallAddress = student.PostalAddress;
                student_Tbl.Semester = student.Semester;
                student_Tbl.CourseId = student.CourseId;
                student_Tbl.StatusId = 1;

                entity.student_tbl.Add(student_Tbl);
                //entity.SaveChanges();
                try
                {
                    entity.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException e)
                {

                    try
                    {
                        throw e.InnerException;
                    }
                    catch (System.Data.Entity.Core.UpdateException d)
                    {

                        System.Windows.Forms.MessageBox.Show(d.InnerException.Message);
                    }

                }

                return student_Tbl.StudentId;
            }
        }


        internal static Student SearchStudent(int ID)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.student_tbl
                              where i.StudentId == ID & i.StatusId == 1
                              select i).Single();
                if (result == null)
                {
                    return null;
                }
                else
                {
                    return new Student
                    {
                        ID = result.StudentId,
                        Name = result.Name,
                        Surname = result.Surname,
                        Gender = result.Gender,
                        Cell = result.Cell,
                        Email = result.Email,
                        PostalAddress = result.PostallAddress,
                        CourseId = result.CourseId,
                        Semester = result.Semester,
                        StatusId = result.StatusId
                    };
                }
               
            }
        }


        internal static void EditStudent(Student st)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from r in entity.student_tbl
                              where r.StudentId == st.ID
                              select r).SingleOrDefault();


                result.Name = st.Name;
                result.Surname = st.Surname;
                result.Cell = st.Cell;
                result.Email = st.Email;
                result.PostallAddress = st.PostalAddress;
                result.Semester = st.Semester;
                result.CourseId = st.CourseId;
                result.StatusId = st.StatusId;
                entity.SaveChanges();
            }
        }


        internal static void RemoveStudent(Student student)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.student_tbl
                              where i.StudentId == student.ID
                              select i).Single();

                result.StatusId = 2;
                entity.SaveChanges();
            }
        }


        internal static string GetCourseName(int ID)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.course_tble
                              where i.CourseId == ID
                              select i.CourseName).Single();

                return result;
            }
        }

        internal static string GetStausName(int ID)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.status_tbl
                              where i.StatusId == ID
                              select i.StatusName).Single();

                return result;
            }
        }

        internal static int GetCourseID(string ID)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.course_tble
                              where i.CourseName == ID
                              select i.CourseId).Single();

                return int.Parse(result.ToString());
            }
        }

        internal static int GetSatusID(string ID)
        {
            using (dbEntities entity = new dbEntities())
            {
                var result = (from i in entity.status_tbl
                              where i.StatusName == ID
                              select i.StatusId).Single();

                return int.Parse(result.ToString());
            }
        }




        internal static List<Student> GetStudents()
        {
            List<Student> studl = new List<Student>();

            using (dbEntities ent = new dbEntities())
            {
                var results = (from s in ent.student_tbl
                               where s.StatusId == 1
                               select s).ToList<student_tbl>();

                foreach (var item in results)
                {
                    studl.Add(new Student
                    {
                        ID = item.StudentId,
                        Name = item.Name,
                        Surname = item.Surname,
                        Gender = item.Gender,
                        Cell = item.Cell,
                        Email = item.Email,
                        PostalAddress = item.PostallAddress,
                        CourseId = item.CourseId,
                        Semester = item.Semester,
                        StatusId = item.StatusId
                    });
                }
                return studl;
            }
        }



        internal static List<Teacher> GetTeachers()
        {
            List<Teacher> studl = new List<Teacher>();

            using (dbEntities ent = new dbEntities())
            {
                var results = (from s in ent.teacher_tbl
                               where s.StatusId == 1
                               select s).ToList<teacher_tbl>();

                foreach (var item in results)
                {
                    studl.Add(new Teacher
                    {
                        ID = item.TeacherId,
                        Name = item.Name,
                        Surname = item.Surname,
                        Gender = item.Gender,
                        Cell = item.Cell,
                        Email = item.Email,
                        PIN = item.PIN,
                        StatusId = item.StatusId
                    });
                }
                return studl;
            }
        }


        internal static void InsertGaurdian(Gaurdian gd)
        {
            using (dbEntities entity = new dbEntities())
            {
                gaurdian_tbl dgg = new gaurdian_tbl();

                dgg.Name = gd.Name;
                dgg.Surname = gd.Surname;
                dgg.Gender = gd.Gender;
                dgg.Cell = gd.Cell;
                dgg.Email = gd.Email;
                dgg.StudentId = dgg.StudentId;

                entity.gaurdian_tbl.Add(dgg);
                entity.SaveChanges();
            }
        }


        internal static void InsertTeacher(Teacher gd)
        {
            using (dbEntities entity = new dbEntities())
            {
                teacher_tbl dgg = new teacher_tbl();

                dgg.Name = gd.Name;
                dgg.Surname = gd.Surname;
                dgg.Gender = gd.Gender;
                dgg.Cell = gd.Cell;
                dgg.Email = gd.Email;
                dgg.StatusId = 1;
                dgg.PIN = gd.PIN;

                entity.teacher_tbl.Add(dgg);
                entity.SaveChanges();
            }
        }



        internal static void EditTeacher(Teacher gd)
        {
            using (dbEntities entity = new dbEntities())
            {
                var dgg = (from i in entity.teacher_tbl
                           where i.TeacherId == gd.ID
                           select i).SingleOrDefault();

                dgg.Name = gd.Name;
                dgg.Surname = gd.Surname;
                dgg.Gender = gd.Gender;
                dgg.Cell = gd.Cell;
                dgg.Email = gd.Email;
                dgg.StatusId = dgg.StatusId;
                dgg.PIN = gd.PIN;
                dgg.StatusId = gd.StatusId;

                entity.SaveChanges();
            }
        }



        internal static void RemoveTeacher(Teacher tc)
        {
            using (dbEntities ent = new dbEntities())
            {
                var r = (from i in ent.teacher_tbl
                         where i.TeacherId == tc.ID
                         select i).Single();

                r.StatusId = 2;
                ent.SaveChanges();

            }
        }



        internal static void InsertCourse(Course cs)
        {
            using (dbEntities f = new dbEntities())
            {
                f.course_tble.Add(new course_tble
                {
                    CourseCode = cs.CourseCode,
                    CourseName = cs.CourseName,
                    CourseDuration = cs.Duration,
                    StatusId = 1
                });

                f.SaveChanges();

            }
        }



        internal static List<Course> GetCourses()
        {
            List<Course> cs = new List<Course>();

            using (dbEntities d = new dbEntities())
            {
                var e = (from i in d.course_tble
                         where i.StatusId == 1
                         select i).ToList<course_tble>();

                foreach (var item in e)
                {
                    cs.Add(new Course
                    {
                        CourseId = item.CourseId,
                        CourseCode = item.CourseCode,
                        CourseName = item.CourseName,
                        Duration = item.CourseDuration,
                        StatusId = item.StatusId
                    });
                }

                return cs;
            }
        }


       


        internal static void InsertPayments(Payments payments)
        {
            using (dbEntities k = new dbEntities())
            {
                k.payment_tbl.Add(new payment_tbl
                {
                    StudentId = payments.StudentId,
                    Amount = payments.Amount,
                    CaptureDate = payments.PaymentDate,
                    UserId = payments.UserId
                    
                });
                k.SaveChanges();
            }
        }


        internal static List<Payments> GetPayments(int studentID)
        {
            List<Payments> f = new List<Payments>();
            using (dbEntities ent = new dbEntities())
            {
                var stud = (from i in ent.student_tbl
                            where i.StudentId == studentID
                            select i).SingleOrDefault<student_tbl>() ;
                var results = (from i in ent.payment_tbl
                               where i.StudentId == studentID 
                               select i).ToList<payment_tbl>();

                if (stud == null)
                {
                    return null;
                }
                else
                {
                    if (results.Count == 0)
                    {
                        return null;
                    }
                    foreach (var item in results)
                    {
                        f.Add(new Payments
                        {
                            PaymentId = item.PaymentId,
                            StudentId = item.StudentId,
                            PaymentDate = item.CaptureDate,
                            Amount = item.Amount,
                            UserId = item.UserId
                        });
                    }
                    return f;
                }
                
            }
        }

    }
}
