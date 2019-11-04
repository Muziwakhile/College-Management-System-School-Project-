namespace CollegeManagementSystem
{
    partial class GaurdianFrm
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
            this.GenderCmb = new System.Windows.Forms.ComboBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.CellTxt = new System.Windows.Forms.TextBox();
            this.Studenttxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.CellLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RegistraNumLbl = new System.Windows.Forms.Label();
            this.Gaurdiantxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenderCmb
            // 
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCmb.Location = new System.Drawing.Point(242, 306);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(247, 24);
            this.GenderCmb.TabIndex = 3;
            this.GenderCmb.Text = "Select Gender";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(733, 82);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(247, 22);
            this.Emailtxt.TabIndex = 5;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(242, 161);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(247, 22);
            this.Nametxt.TabIndex = 1;
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(242, 238);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(247, 22);
            this.Surnametxt.TabIndex = 2;
            // 
            // CellTxt
            // 
            this.CellTxt.Location = new System.Drawing.Point(242, 385);
            this.CellTxt.Name = "CellTxt";
            this.CellTxt.Size = new System.Drawing.Size(247, 22);
            this.CellTxt.TabIndex = 4;
            this.CellTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CellTxt_KeyPress);
            // 
            // Studenttxt
            // 
            this.Studenttxt.Location = new System.Drawing.Point(733, 161);
            this.Studenttxt.Name = "Studenttxt";
            this.Studenttxt.ReadOnly = true;
            this.Studenttxt.Size = new System.Drawing.Size(247, 22);
            this.Studenttxt.TabIndex = 26;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(532, 79);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(51, 24);
            this.EmailLbl.TabIndex = 25;
            this.EmailLbl.Text = "Email";
            // 
            // CellLbl
            // 
            this.CellLbl.AutoSize = true;
            this.CellLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellLbl.Location = new System.Drawing.Point(27, 385);
            this.CellLbl.Name = "CellLbl";
            this.CellLbl.Size = new System.Drawing.Size(101, 24);
            this.CellLbl.TabIndex = 24;
            this.CellLbl.Text = "Cell Number";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(27, 306);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(64, 24);
            this.GenderLbl.TabIndex = 23;
            this.GenderLbl.Text = "Gender";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.Location = new System.Drawing.Point(27, 235);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(77, 24);
            this.SurnameLbl.TabIndex = 22;
            this.SurnameLbl.Text = "Surname";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(27, 158);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 24);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "Name";
            // 
            // RegistraNumLbl
            // 
            this.RegistraNumLbl.AutoSize = true;
            this.RegistraNumLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistraNumLbl.Location = new System.Drawing.Point(532, 161);
            this.RegistraNumLbl.Name = "RegistraNumLbl";
            this.RegistraNumLbl.Size = new System.Drawing.Size(180, 24);
            this.RegistraNumLbl.TabIndex = 20;
            this.RegistraNumLbl.Text = "Student Registration ID";
            // 
            // Gaurdiantxt
            // 
            this.Gaurdiantxt.Location = new System.Drawing.Point(242, 82);
            this.Gaurdiantxt.Name = "Gaurdiantxt";
            this.Gaurdiantxt.ReadOnly = true;
            this.Gaurdiantxt.Size = new System.Drawing.Size(247, 22);
            this.Gaurdiantxt.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gaurdian Registration ID";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(377, 436);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 43);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(581, 436);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(112, 43);
            this.Closebtn.TabIndex = 7;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(308, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(302, 32);
            this.TitleLbl.TabIndex = 36;
            this.TitleLbl.Text = "Gaurdian Information";
            // 
            // GaurdianFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 485);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Gaurdiantxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderCmb);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Surnametxt);
            this.Controls.Add(this.CellTxt);
            this.Controls.Add(this.Studenttxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.CellLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.RegistraNumLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GaurdianFrm";
            this.Text = "Gaurdian Information";
            this.Load += new System.EventHandler(this.GaurdianFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderCmb;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.TextBox CellTxt;
        private System.Windows.Forms.TextBox Studenttxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label CellLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label RegistraNumLbl;
        private System.Windows.Forms.TextBox Gaurdiantxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label TitleLbl;
    }
}