namespace CollegeManagementSystem
{
    partial class TeacherR
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
            this.PINTxt = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GenderCmb = new System.Windows.Forms.ComboBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Surnametext = new System.Windows.Forms.TextBox();
            this.Celltxt = new System.Windows.Forms.TextBox();
            this.TeacherRegtxt = new System.Windows.Forms.TextBox();
            this.PINLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.CellLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RegistraNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PINTxt
            // 
            this.PINTxt.Location = new System.Drawing.Point(811, 173);
            this.PINTxt.Name = "PINTxt";
            this.PINTxt.Size = new System.Drawing.Size(247, 22);
            this.PINTxt.TabIndex = 52;
            this.PINTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PINTxt_KeyPress);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(367, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(299, 32);
            this.TitleLbl.TabIndex = 64;
            this.TitleLbl.Text = "Teacher Registration";
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(947, 463);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(111, 42);
            this.Closebtn.TabIndex = 54;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(811, 463);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(111, 42);
            this.SaveBtn.TabIndex = 53;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GenderCmb
            // 
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCmb.Location = new System.Drawing.Point(272, 318);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(247, 24);
            this.GenderCmb.TabIndex = 48;
            this.GenderCmb.Text = "Select Gender";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(811, 94);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(247, 22);
            this.Emailtxt.TabIndex = 50;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(272, 173);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(247, 22);
            this.Nametxt.TabIndex = 46;
            // 
            // Surnametext
            // 
            this.Surnametext.Location = new System.Drawing.Point(272, 250);
            this.Surnametext.Name = "Surnametext";
            this.Surnametext.Size = new System.Drawing.Size(247, 22);
            this.Surnametext.TabIndex = 47;
            // 
            // Celltxt
            // 
            this.Celltxt.Location = new System.Drawing.Point(272, 397);
            this.Celltxt.Name = "Celltxt";
            this.Celltxt.Size = new System.Drawing.Size(247, 22);
            this.Celltxt.TabIndex = 49;
            this.Celltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Celltxt_KeyPress);
            // 
            // TeacherRegtxt
            // 
            this.TeacherRegtxt.Location = new System.Drawing.Point(272, 94);
            this.TeacherRegtxt.Name = "TeacherRegtxt";
            this.TeacherRegtxt.ReadOnly = true;
            this.TeacherRegtxt.Size = new System.Drawing.Size(247, 22);
            this.TeacherRegtxt.TabIndex = 63;
            // 
            // PINLbl
            // 
            this.PINLbl.AutoSize = true;
            this.PINLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLbl.Location = new System.Drawing.Point(610, 170);
            this.PINLbl.Name = "PINLbl";
            this.PINLbl.Size = new System.Drawing.Size(38, 24);
            this.PINLbl.TabIndex = 62;
            this.PINLbl.Text = "PIN";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(610, 91);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(51, 24);
            this.EmailLbl.TabIndex = 60;
            this.EmailLbl.Text = "Email";
            // 
            // CellLbl
            // 
            this.CellLbl.AutoSize = true;
            this.CellLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellLbl.Location = new System.Drawing.Point(57, 397);
            this.CellLbl.Name = "CellLbl";
            this.CellLbl.Size = new System.Drawing.Size(101, 24);
            this.CellLbl.TabIndex = 59;
            this.CellLbl.Text = "Cell Number";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(57, 318);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(64, 24);
            this.GenderLbl.TabIndex = 58;
            this.GenderLbl.Text = "Gender";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.Location = new System.Drawing.Point(57, 247);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(77, 24);
            this.SurnameLbl.TabIndex = 57;
            this.SurnameLbl.Text = "Surname";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(57, 170);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 24);
            this.NameLbl.TabIndex = 56;
            this.NameLbl.Text = "Name";
            // 
            // RegistraNumLbl
            // 
            this.RegistraNumLbl.AutoSize = true;
            this.RegistraNumLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistraNumLbl.Location = new System.Drawing.Point(57, 91);
            this.RegistraNumLbl.Name = "RegistraNumLbl";
            this.RegistraNumLbl.Size = new System.Drawing.Size(182, 24);
            this.RegistraNumLbl.TabIndex = 55;
            this.RegistraNumLbl.Text = "Teacher Registration ID";
            // 
            // TeacherR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 530);
            this.Controls.Add(this.PINTxt);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.GenderCmb);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Surnametext);
            this.Controls.Add(this.Celltxt);
            this.Controls.Add(this.TeacherRegtxt);
            this.Controls.Add(this.PINLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.CellLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.RegistraNumLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherR";
            this.Text = "Teacher Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PINTxt;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox GenderCmb;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Surnametext;
        private System.Windows.Forms.TextBox Celltxt;
        private System.Windows.Forms.TextBox TeacherRegtxt;
        private System.Windows.Forms.Label PINLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label CellLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label RegistraNumLbl;
    }
}