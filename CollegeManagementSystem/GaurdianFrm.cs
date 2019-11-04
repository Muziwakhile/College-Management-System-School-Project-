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
    public partial class GaurdianFrm : Form
    {
        public GaurdianFrm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(Studenttxt.Text);
            if (Emailtxt.Text != "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Emailtxt.Text);
                    var result = FormOperations.ValidateFields(Nametxt.Text, Surnametxt.Text, GenderCmb.SelectedItem.ToString(), CellTxt.Text, studentid);

                    if (result)
                    {
                        Gaurdian gaurdian = new Gaurdian();

                        gaurdian.Name = Nametxt.Text;
                        gaurdian.Surname = Surnametxt.Text;
                        gaurdian.Gender = GenderCmb.SelectedItem.ToString();
                        gaurdian.Cell = CellTxt.Text;
                        gaurdian.Email = Emailtxt.Text;
                        gaurdian.StudentId = studentid;

                        DataAccess.InsertGaurdian(gaurdian);

                        DialogResult dl = MessageBox.Show("Gaudian Saved Successfully. Do You want to Proceesd to Payment Information?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dl == DialogResult.Yes)
                        {
                            FormOperations._ID = FormOperations.student.ID;
                            FormOperations.OpenPayment();
                            this.Close();
                        }
                        else
                        {
                            //FormOperations.student = null;
                            FormOperations._ID = 0;
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
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Empty field Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }

        private void GaurdianFrm_Load(object sender, EventArgs e)
        {
            //GenderCmb.Items.AddRange(new object[] { Gender.Male, Gender.Female });
            Studenttxt.Text = FormOperations.student.ID.ToString();
        }

        private void CellTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }
    }
}
