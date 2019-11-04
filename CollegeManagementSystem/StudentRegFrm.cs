using CollegeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class StudentRegFrm : Form
    {
        public StudentRegFrm()
        {
            InitializeComponent();
            

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

           

            int value = 0;
            int semester = 0;
            if (CourseCmb.SelectedValue.ToString() != null & SemesterCmb.SelectedItem != null)
            {
                value = int.Parse(CourseCmb.SelectedValue.ToString());
                semester = int.Parse(SemesterCmb.SelectedItem.ToString());
            }
            if (EmailTxt.Text != "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(EmailTxt.Text);
                    var result = FormOperations.ValidateFields(NameTxt.Text, SurnameTxt.Text, GenderCmb.SelectedItem, CellNTxt.Text, value, semester);
                    if (result)
                    {
                        FormOperations.student.Name = NameTxt.Text;
                        FormOperations.student.Surname = SurnameTxt.Text;
                        FormOperations.student.Gender = GenderCmb.SelectedItem.ToString();
                        FormOperations.student.Cell = CellNTxt.Text;
                        FormOperations.student.Email = EmailTxt.Text;
                        FormOperations.student.PostalAddress = Postaltxt.Text;
                        FormOperations.student.Semester = semester;
                        FormOperations.student.CourseId = value;
                        //FormOperations.student.StatusId = int.Parse(StatusCmb.SelectedValue.ToString());

                        FormOperations.student.ID = DataAccess.InsertStudent(FormOperations.student);

                        MessageBox.Show("Student Saved Successfully. Please Proceesd to Gaurdian Information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormOperations.OpenGaurdian();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In All Fields", "Empty field Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("The Email entered is not a valid email address","Invalid Email",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Empty Fields Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }

        private void StudentRegFrm_Load(object sender, EventArgs e)
        {

            CourseCmb.DataSource = DataAccess.GetCourses();
            CourseCmb.DisplayMember = "CourseName";
            CourseCmb.ValueMember = "CourseId";
            CourseCmb.Text = "Select Course";

            //StatusCmb.DataSource = DataAccess.GetStatuses();
            //StatusCmb.DisplayMember = "StatusName";
            //StatusCmb.ValueMember = "StatusId";
            //StatusCmb.Text = "Select Status";

            //GenderCmb.Items.AddRange( new object[] { Gender.Male, Gender.Female });
           
        }

        private void CellNTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c !=8)
            {
                e.Handled = true;
            }
        }

       

        

        //private void courseBindingSource_CurrentChanged(object sender, EventArgs e)
        //{
        //    CourseCmb.Items.AddRange(new object[] {  });
        //}
    }
}
