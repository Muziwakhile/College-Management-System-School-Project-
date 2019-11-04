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
    public partial class StudentEdit : Form
    {
        public StudentEdit()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            StudentRegTxt.Clear();
            NameTxt.Clear();
            SurnameTxt.Clear();
            GenderCmb.ResetText();
            CellNTxt.Clear();
            EmailTxt.Clear();
            Postaltxt.ResetText();
            CourseCmb.ResetText();
            Statuscmb.ResetText();
            SemesterCmb.ResetText();
            dataGridView1.DataSource = DataAccess.GetStudents();

            dataGridView1.Columns["ID"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Surname"].DisplayIndex = 2;
            dataGridView1.Columns["Gender"].DisplayIndex = 3;
            dataGridView1.Columns["Cell"].DisplayIndex = 4;
            dataGridView1.Columns["Email"].DisplayIndex = 5;
            dataGridView1.Columns["PostalAddress"].DisplayIndex = 6;
            dataGridView1.Columns["CourseId"].DisplayIndex = 7;
            dataGridView1.Columns["Semester"].DisplayIndex = 8;
            dataGridView1.Columns["StatusId"].DisplayIndex = 9;

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int value = 0;
            int semester = 0;
            if (CourseCmb.Text.ToString() != null & SemesterCmb.SelectedItem != null)
            {
                value =DataAccess.GetCourseID(CourseCmb.Text.ToString());
                semester = int.Parse(SemesterCmb.SelectedItem.ToString());
            }
            if (EmailTxt.Text =="")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(EmailTxt.Text);
                    var result = FormOperations.ValidateFields(NameTxt.Text, SurnameTxt.Text, GenderCmb.SelectedItem, CellNTxt.Text, value, semester);
                    if (result)
                    {
                        Student stud = new Student
                        {
                            ID = int.Parse(StudentRegTxt.Text),
                            Name = NameTxt.Text,
                            Surname = SurnameTxt.Text,
                            Gender = GenderCmb.SelectedItem.ToString(),
                            Cell = CellNTxt.Text,
                            Email = EmailTxt.Text,
                            PostalAddress = Postaltxt.Text,
                            Semester = semester,
                            CourseId = value,
                            StatusId = DataAccess.GetSatusID(Statuscmb.Text.ToString())
                        };

                        //FormOperations.student.StatusId = int.Parse(StatusCmb.SelectedValue.ToString());

                        DataAccess.EditStudent(stud);

                        MessageBox.Show("Student Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //FormOperations.OpenGaurdian();
                        //this.Close();
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In All Fields", "Empty field Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("The Email entered is not a valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Empty field Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {
            CourseCmb.DataSource = DataAccess.GetCourses();
            CourseCmb.DisplayMember = "CourseName";
            CourseCmb.ValueMember = "CourseId";
            CourseCmb.Text = "Select Course";

            Statuscmb.DataSource = DataAccess.GetStatuses();
            Statuscmb.DisplayMember = "StatusName";
            Statuscmb.ValueMember = "StatusId";
            Statuscmb.Text = "Select Status";

            Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Statuscmb.Text = "";
                CourseCmb.Text = "";
                StudentRegTxt.Text =  row.Cells["ID"].Value.ToString();
                NameTxt.Text = row.Cells["Name"].Value.ToString();
                SurnameTxt.Text = row.Cells["Surname"].Value.ToString();
                GenderCmb.SelectedItem = row.Cells["Gender"].Value.ToString();
                CellNTxt.Text = row.Cells["Cell"].Value.ToString();
                EmailTxt.Text = row.Cells["Email"].Value.ToString();
                Postaltxt.SelectedText = row.Cells["PostalAddress"].Value.ToString();
                CourseCmb.SelectedText = DataAccess.GetCourseName( int.Parse(row.Cells["CourseId"].Value.ToString()));
                SemesterCmb.SelectedItem = row.Cells["Semester"].Value.ToString();
                Statuscmb.SelectedText = DataAccess.GetStausName(int.Parse(row.Cells["StatusId"].Value.ToString()));

            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }
    }
}
