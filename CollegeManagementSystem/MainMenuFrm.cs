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
    public partial class MainMenuFrm : Form
    {
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {

            //open the the student regstration 
            FormOperations.OpenStudReg();

            //close the current form
            this.Close();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            //open the payment form
            FormOperations.OpenPayment();

            //close the current form
            this.Close();
        }

        private void TeacherBtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenTeacherReg();
            this.Close();
        }

        private void ViewStudentBtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenStudentEdit();
            this.Close();
        }

        private void ViewteacherBtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenTeacherEdit();
            this.Close();
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenCourseReg();
            this.Close();
        }
    }
}
