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
    public partial class CourseReg : Form
    {
        public CourseReg()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            CourseCtxt.Clear();
            CourseNtxt.Clear();
            CourseDtxt.Clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (CourseCtxt.Text != "" | CourseNtxt.Text !="" | CourseDtxt.Text!="")
            {
                Course c = new Course {
                    CourseCode = CourseCtxt.Text,
                    CourseName = CourseNtxt.Text,
                    Duration = int.Parse(CourseDtxt.Text)

                };
                DataAccess.InsertCourse(c);


                DialogResult dl = MessageBox.Show("Course Saved Successfully. Do You want to Proceesd with another Registration?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dl == DialogResult.Yes)
                {
                    Refresh();
                }
                else
                {
                    FormOperations.OpenMenu();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Empty Field Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }
    }
}
