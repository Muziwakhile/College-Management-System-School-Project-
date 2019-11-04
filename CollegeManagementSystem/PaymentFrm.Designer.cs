namespace CollegeManagementSystem
{
    partial class PaymentFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Amounttxt = new System.Windows.Forms.TextBox();
            this.Studenttxt = new System.Windows.Forms.TextBox();
            this.Paytxt = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.StudentRegLbl = new System.Windows.Forms.Label();
            this.PaymentIdLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrencyLbl = new System.Windows.Forms.Label();
            this.Amounttxtx = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.Searchtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Amounttxt);
            this.panel1.Controls.Add(this.Studenttxt);
            this.panel1.Controls.Add(this.Paytxt);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.StudentRegLbl);
            this.panel1.Controls.Add(this.PaymentIdLbl);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 314);
            this.panel1.TabIndex = 0;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(724, 252);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(83, 46);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(525, 8);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(83, 30);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(247, 12);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(244, 22);
            this.Searchtxt.TabIndex = 1;
            this.Searchtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Searchtxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Registration ID";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Location = new System.Drawing.Point(247, 223);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(244, 22);
            this.Amounttxt.TabIndex = 3;
            this.Amounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amounttxt_KeyPress);
            // 
            // Studenttxt
            // 
            this.Studenttxt.Location = new System.Drawing.Point(247, 155);
            this.Studenttxt.Name = "Studenttxt";
            this.Studenttxt.ReadOnly = true;
            this.Studenttxt.Size = new System.Drawing.Size(244, 22);
            this.Studenttxt.TabIndex = 5;
            // 
            // Paytxt
            // 
            this.Paytxt.Location = new System.Drawing.Point(247, 85);
            this.Paytxt.Name = "Paytxt";
            this.Paytxt.ReadOnly = true;
            this.Paytxt.Size = new System.Drawing.Size(244, 22);
            this.Paytxt.TabIndex = 4;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(35, 228);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(103, 17);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "Amount Paying";
            // 
            // StudentRegLbl
            // 
            this.StudentRegLbl.AutoSize = true;
            this.StudentRegLbl.Location = new System.Drawing.Point(35, 160);
            this.StudentRegLbl.Name = "StudentRegLbl";
            this.StudentRegLbl.Size = new System.Drawing.Size(154, 17);
            this.StudentRegLbl.TabIndex = 2;
            this.StudentRegLbl.Text = "Student Registration ID";
            // 
            // PaymentIdLbl
            // 
            this.PaymentIdLbl.AutoSize = true;
            this.PaymentIdLbl.Location = new System.Drawing.Point(35, 85);
            this.PaymentIdLbl.Name = "PaymentIdLbl";
            this.PaymentIdLbl.Size = new System.Drawing.Size(80, 17);
            this.PaymentIdLbl.TabIndex = 1;
            this.PaymentIdLbl.Text = "Payment ID";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(605, 252);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(83, 46);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 314);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // CurrencyLbl
            // 
            this.CurrencyLbl.AutoSize = true;
            this.CurrencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLbl.Location = new System.Drawing.Point(138, 696);
            this.CurrencyLbl.Name = "CurrencyLbl";
            this.CurrencyLbl.Size = new System.Drawing.Size(26, 25);
            this.CurrencyLbl.TabIndex = 7;
            this.CurrencyLbl.Text = "E";
            // 
            // Amounttxtx
            // 
            this.Amounttxtx.AutoSize = true;
            this.Amounttxtx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amounttxtx.Location = new System.Drawing.Point(159, 696);
            this.Amounttxtx.Name = "Amounttxtx";
            this.Amounttxtx.Size = new System.Drawing.Size(24, 25);
            this.Amounttxtx.TabIndex = 6;
            this.Amounttxtx.Text = "0";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(10, 696);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(110, 25);
            this.TotalLbl.TabIndex = 5;
            this.TotalLbl.Text = "Total Paid";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(191, 4);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(409, 32);
            this.TitleLbl.TabIndex = 8;
            this.TitleLbl.Text = "Student Payment Information";
            // 
            // PaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 727);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.CurrencyLbl);
            this.Controls.Add(this.Amounttxtx);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentFrm";
            this.Text = "PaymentFrm";
            this.Load += new System.EventHandler(this.PaymentFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label StudentRegLbl;
        private System.Windows.Forms.Label PaymentIdLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amounttxt;
        private System.Windows.Forms.TextBox Studenttxt;
        private System.Windows.Forms.TextBox Paytxt;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label CurrencyLbl;
        private System.Windows.Forms.Label Amounttxtx;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label TitleLbl;
    }
}