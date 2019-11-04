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
    public partial class TeacherR : Form
    {
        public TeacherR()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Emailtxt.Text != "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Emailtxt.Text);
                    var result = FormOperations.ValidateFields(Nametxt.Text, Surnametext.Text, GenderCmb.SelectedItem.ToString(), Celltxt.Text);

                    if (result)
                    {
                        DTO.Teacher teacher = new DTO.Teacher();

                        teacher.Name = Nametxt.Text;
                        teacher.Surname = Surnametext.Text;
                        teacher.Gender = GenderCmb.SelectedItem.ToString();
                        teacher.Cell = Celltxt.Text;
                        teacher.Email = Emailtxt.Text;
                        teacher.PIN = PINTxt.Text;


                        DataAccess.InsertTeacher(teacher);

                        DialogResult dl = MessageBox.Show("Teacer Saved Successfully. Do You want to Proceesd with another Registration?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dl == DialogResult.Yes)
                        {
                            TeacherRegtxt.Clear();
                            Nametxt.Clear();
                            Surnametext.Clear();
                            GenderCmb.ResetText();
                            Celltxt.Clear();
                            PINTxt.Clear();
                            Emailtxt.Clear();
                        }
                        else
                        {
                            FormOperations.OpenMenu();
                            this.Close();
                        }

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
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
             
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Empty field Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Celltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void PINTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }
    }

}

