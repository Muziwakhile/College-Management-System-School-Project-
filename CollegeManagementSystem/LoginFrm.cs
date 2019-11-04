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
    public partial class LoginFrm : Form
    {
        
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            if (UsernameTxt.Text == "" || PasswordTxt.Text == "" )
            {
                MessageBox.Show("Please Fill in All Fields","Empty Fields Detected",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FormOperations.user = DataAccess.GetUsers(UsernameTxt.Text, PasswordTxt.Text);
                if (FormOperations.user != null)
                {
                    FormOperations.OpenMenu();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password. Please Try Again");
                    UsernameTxt.Clear();
                    PasswordTxt.Clear();
                }
                
            }
            
        }
    }
}
