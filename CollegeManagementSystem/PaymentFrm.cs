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
    public partial class PaymentFrm : Form
    {

        private void Refresh(int ID)
        {
            double? am = 0;
            var d = DataAccess.GetPayments(ID);
          
            if (d == null)
            {
                Studenttxt.Text = "";
                Paytxt.Text = "";
            }
            else
            {
                
                var r = DataAccess.GetPayments(ID).SingleOrDefault();
                Studenttxt.Text = r.StudentId.ToString();
                Paytxt.Text = r.PaymentId.ToString();
                foreach (var item in d)
                {
                    am += item.Amount;
                }
                dataGridView1.DataSource = d;
                Amounttxtx.Text = am.ToString();
            }
            

           
        }
        public PaymentFrm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            FormOperations.OpenMenu();
            this.Close();

        }

        private void PaymentFrm_Load(object sender, EventArgs e)
        {
            Refresh(FormOperations.student.ID);
            if (FormOperations._ID != 0)
            {
                Studenttxt.Text = FormOperations._ID.ToString();
            }
            else
            {
                FormOperations._ID = 0;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Amounttxt.Text == "")
            {
                MessageBox.Show("Please insert payment amount");
            }
            else
            {
                if (Studenttxt.Text != "")
                {
                    Payments p = new Payments
                    {
                        StudentId = int.Parse(Studenttxt.Text),
                        Amount = double.Parse(Amounttxt.Text),
                        PaymentDate = DateTime.Now,
                        UserId = FormOperations.user.UserId
                    };
                    DataAccess.InsertPayments(p);
                    DialogResult msg = MessageBox.Show("Payment Saved Successfully. Do you want to make other payments?","Payment Notifcation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (DialogResult.No == msg)
                    {
                      
                        FormOperations.OpenMenu();
                        this.Close();
                    }
                    else
                    {
                        Searchtxt.Clear();
                        Paytxt.Clear();
                        Studenttxt.Clear();
                        Amounttxt.Clear();
                        dataGridView1.DataSource = null;
                        Amounttxtx.Text = 0.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please search for student first then enter payment and save");
                }
                
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            double? am = 0;
            if (Searchtxt.Text == "")
            {
                MessageBox.Show("Please Enter student ID in the Search box");
            }
            else
            {
                var s = DataAccess.SearchStudent(int.Parse(Searchtxt.Text));
                if (s != null)
                {
                    var r = DataAccess.GetPayments(s.ID);
                    if (r != null)
                    {
                        Studenttxt.Text = s.ID.ToString();

                        Paytxt.Text = r[0].PaymentId.ToString();
                        foreach (var item in r)
                        {
                            am += item.Amount;
                        }
                        dataGridView1.DataSource = r;
                        Amounttxtx.Text = am.ToString();
                    }
                    else
                    {
                        Studenttxt.Text = s.ID.ToString();
                    }
                }
               
            }
            
           
            //Refresh(int.Parse(Searchtxt.Text));
        }

        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

     

        private void Amounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                                 && e.KeyChar != 8)
                e.Handled = true;
        }

       
    }
}
