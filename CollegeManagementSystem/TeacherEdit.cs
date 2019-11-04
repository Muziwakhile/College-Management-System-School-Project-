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
    public partial class TeacherEdit : Form
    {
        public TeacherEdit()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            TeacherRegtxt.Clear();
            Nametxt.Clear();
            Surnametext.Clear();
            GenderCmb.ResetText();
            Celltxt.Clear();
            PINTxt.Clear();
            Emailtxt.Clear();
            Statuscmb.ResetText();
            dataGridView1.DataSource = DataAccess.GetTeachers();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Emailtxt.Text == "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Emailtxt.Text);
                    var result = FormOperations.ValidateFields(Nametxt.Text, Surnametext.Text, GenderCmb.SelectedItem.ToString(), Celltxt.Text);

                    if (result)
                    {
                        DTO.Teacher teacher = new DTO.Teacher();

                        teacher.ID = int.Parse(TeacherRegtxt.Text);
                        teacher.Name = Nametxt.Text;
                        teacher.Surname = Surnametext.Text;
                        teacher.Gender = GenderCmb.SelectedItem.ToString();
                        teacher.Cell = Celltxt.Text;
                        teacher.Email = Emailtxt.Text;
                        teacher.PIN = PINTxt.Text;
                        teacher.StatusId = DataAccess.GetSatusID(Statuscmb.Text.ToString());

                        DataAccess.EditTeacher(teacher);

                        DialogResult dl = MessageBox.Show("Teacer Updated Successfully. Do You want to Proceesd with another Registration?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Statuscmb.Text = "";
               
                TeacherRegtxt.Text = row.Cells["ID"].Value.ToString();
                Nametxt.Text = row.Cells["Name"].Value.ToString();
                Surnametext.Text = row.Cells["Surname"].Value.ToString();
                GenderCmb.SelectedItem = row.Cells["Gender"].Value.ToString();
                Celltxt.Text = row.Cells["Cell"].Value.ToString();
                Emailtxt.Text = row.Cells["Email"].Value.ToString();
                PINTxt.Text = row.Cells["PIN"].Value.ToString(); 
                Statuscmb.SelectedText = DataAccess.GetStausName(int.Parse(row.Cells["StatusId"].Value.ToString()));

            }
        }

        private void TeacherEdit_Load(object sender, EventArgs e)
        {
            Statuscmb.DataSource = DataAccess.GetStatuses();
            Statuscmb.DisplayMember = "StatusName";
            Statuscmb.ValueMember = "StatusId";
            Statuscmb.Text = "Select Status";

            Refresh();

            dataGridView1.Columns["ID"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Surname"].DisplayIndex = 2;
            dataGridView1.Columns["Gender"].DisplayIndex = 3;
            dataGridView1.Columns["Cell"].DisplayIndex = 4;
            dataGridView1.Columns["Email"].DisplayIndex = 5;
            dataGridView1.Columns["PIN"].DisplayIndex = 6;
            dataGridView1.Columns["StatusId"].DisplayIndex = 7;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();
        }
    }
}
