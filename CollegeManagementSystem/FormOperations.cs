using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.DTO;
using CollegeManagementSystem.Models;
namespace CollegeManagementSystem
{
    //enum Gender
    //{
    //    Male = 1,
    //    Female
    //}

    enum Status
    {
        Active = 1,
        None_Active,
        Deleted
    }

    
    class FormOperations
    {
        static bool validation = true;
        public static Users user = new Users();
        public static Student student = new Student();
        public static int _ID;
        internal static void OpenStudReg()
        {
            using (dbEntities ent = new dbEntities())
            {
                var result = (from i in ent.user_tbl
                              select i).SingleOrDefault();
            }
            StudentRegFrm stfrm = new StudentRegFrm();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }

        internal static void OpenMenu()
        {
            MainMenuFrm stfrm = new MainMenuFrm();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }

        internal static void OpenGaurdian()
        {
            GaurdianFrm stfrm = new GaurdianFrm();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }


        internal static void OpenCourseReg()
        {
            CourseReg stfrm = new CourseReg();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }



        internal static void OpenPayment()
        {
            PaymentFrm stfrm = new PaymentFrm();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }


        internal static void OpenStudentEdit()
        {
            StudentEdit stfrm = new StudentEdit();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }

        internal static void OpenTeacherReg()
        {
            TeacherR stfrm = new TeacherR();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }


        internal static void OpenTeacherEdit()
        {
            TeacherEdit stfrm = new TeacherEdit();
            stfrm.MdiParent = Application.OpenForms["MainFrm"];
            stfrm.StartPosition = FormStartPosition.CenterScreen;
            stfrm.Show();
        }


        internal static bool ValidateFields(string name, string surname,object gender, string cell)
        {
            if (name == "" | surname == "" | gender == null | cell == "" )
            {
                
                validation = false;
            }
            return validation;
           
        }
        internal static bool ValidateFields(string name, string surname, object gender, string cell,int Student)
        {
            if (name == "" | surname == "" | gender == null | cell == "" | Student == 0)
            {
                validation = false;
            }
            return validation;
        }
        internal static bool ValidateFields(string name, string surname, object gender, string cell, int course, int semester)
        {
            if (name == "" | surname == "" | gender == null| cell == "" | course == 0 | semester == 0)
            {
                validation = false;
            }

            return validation;
        }
    }
}
