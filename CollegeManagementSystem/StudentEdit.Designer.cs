namespace CollegeManagementSystem
{
    partial class StudentEdit
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
            this.SemesterCmb = new System.Windows.Forms.ComboBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.GenderCmb = new System.Windows.Forms.ComboBox();
            this.CourseCmb = new System.Windows.Forms.ComboBox();
            this.Postaltxt = new System.Windows.Forms.RichTextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.CellNTxt = new System.Windows.Forms.TextBox();
            this.StudentRegTxt = new System.Windows.Forms.TextBox();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.PostalLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.CellLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RegistraNumLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Statuscmb = new System.Windows.Forms.ComboBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SemesterCmb
            // 
            this.SemesterCmb.DisplayMember = "CourseId";
            this.SemesterCmb.ItemHeight = 16;
            this.SemesterCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SemesterCmb.Location = new System.Drawing.Point(838, 228);
            this.SemesterCmb.MaxDropDownItems = 15;
            this.SemesterCmb.Name = "SemesterCmb";
            this.SemesterCmb.Size = new System.Drawing.Size(247, 24);
            this.SemesterCmb.Sorted = true;
            this.SemesterCmb.TabIndex = 37;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(385, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(282, 32);
            this.TitleLbl.TabIndex = 43;
            this.TitleLbl.Text = "Student Information";
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(975, 441);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(111, 42);
            this.Closebtn.TabIndex = 42;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(839, 441);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(111, 42);
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // GenderCmb
            // 
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCmb.Location = new System.Drawing.Point(300, 296);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(247, 24);
            this.GenderCmb.TabIndex = 29;
            // 
            // CourseCmb
            // 
            this.CourseCmb.DisplayMember = "CourseId";
            this.CourseCmb.ItemHeight = 16;
            this.CourseCmb.Location = new System.Drawing.Point(839, 299);
            this.CourseCmb.MaxDropDownItems = 15;
            this.CourseCmb.Name = "CourseCmb";
            this.CourseCmb.Size = new System.Drawing.Size(247, 24);
            this.CourseCmb.Sorted = true;
            this.CourseCmb.TabIndex = 38;
            this.CourseCmb.Text = "Select Course";
            this.CourseCmb.ValueMember = "CourseId";
            // 
            // Postaltxt
            // 
            this.Postaltxt.Location = new System.Drawing.Point(839, 117);
            this.Postaltxt.Name = "Postaltxt";
            this.Postaltxt.Size = new System.Drawing.Size(247, 66);
            this.Postaltxt.TabIndex = 34;
            this.Postaltxt.Text = "";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(839, 72);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(247, 22);
            this.EmailTxt.TabIndex = 33;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(300, 151);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(247, 22);
            this.NameTxt.TabIndex = 25;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(300, 228);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(247, 22);
            this.SurnameTxt.TabIndex = 27;
            // 
            // CellNTxt
            // 
            this.CellNTxt.Location = new System.Drawing.Point(300, 375);
            this.CellNTxt.Name = "CellNTxt";
            this.CellNTxt.Size = new System.Drawing.Size(247, 22);
            this.CellNTxt.TabIndex = 31;
            // 
            // StudentRegTxt
            // 
            this.StudentRegTxt.Location = new System.Drawing.Point(300, 72);
            this.StudentRegTxt.Name = "StudentRegTxt";
            this.StudentRegTxt.ReadOnly = true;
            this.StudentRegTxt.Size = new System.Drawing.Size(247, 22);
            this.StudentRegTxt.TabIndex = 40;
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLbl.Location = new System.Drawing.Point(638, 296);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(62, 24);
            this.CourseLbl.TabIndex = 39;
            this.CourseLbl.Text = "Course";
            // 
            // SemesterLbl
            // 
            this.SemesterLbl.AutoSize = true;
            this.SemesterLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLbl.Location = new System.Drawing.Point(638, 225);
            this.SemesterLbl.Name = "SemesterLbl";
            this.SemesterLbl.Size = new System.Drawing.Size(81, 24);
            this.SemesterLbl.TabIndex = 36;
            this.SemesterLbl.Text = "Semester";
            // 
            // PostalLbl
            // 
            this.PostalLbl.AutoSize = true;
            this.PostalLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalLbl.Location = new System.Drawing.Point(638, 148);
            this.PostalLbl.Name = "PostalLbl";
            this.PostalLbl.Size = new System.Drawing.Size(119, 24);
            this.PostalLbl.TabIndex = 35;
            this.PostalLbl.Text = "Postal Address";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(638, 69);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(51, 24);
            this.EmailLbl.TabIndex = 32;
            this.EmailLbl.Text = "Email";
            // 
            // CellLbl
            // 
            this.CellLbl.AutoSize = true;
            this.CellLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellLbl.Location = new System.Drawing.Point(85, 375);
            this.CellLbl.Name = "CellLbl";
            this.CellLbl.Size = new System.Drawing.Size(101, 24);
            this.CellLbl.TabIndex = 30;
            this.CellLbl.Text = "Cell Number";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(85, 296);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(64, 24);
            this.GenderLbl.TabIndex = 28;
            this.GenderLbl.Text = "Gender";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.Location = new System.Drawing.Point(85, 225);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(77, 24);
            this.SurnameLbl.TabIndex = 26;
            this.SurnameLbl.Text = "Surname";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(85, 148);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 24);
            this.NameLbl.TabIndex = 24;
            this.NameLbl.Text = "Name";
            // 
            // RegistraNumLbl
            // 
            this.RegistraNumLbl.AutoSize = true;
            this.RegistraNumLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistraNumLbl.Location = new System.Drawing.Point(85, 69);
            this.RegistraNumLbl.Name = "RegistraNumLbl";
            this.RegistraNumLbl.Size = new System.Drawing.Size(180, 24);
            this.RegistraNumLbl.TabIndex = 23;
            this.RegistraNumLbl.Text = "Student Registration ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 246);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Statuscmb
            // 
            this.Statuscmb.DisplayMember = "CourseId";
            this.Statuscmb.ItemHeight = 16;
            this.Statuscmb.Location = new System.Drawing.Point(839, 373);
            this.Statuscmb.MaxDropDownItems = 15;
            this.Statuscmb.Name = "Statuscmb";
            this.Statuscmb.Size = new System.Drawing.Size(247, 24);
            this.Statuscmb.Sorted = true;
            this.Statuscmb.TabIndex = 45;
            this.Statuscmb.Text = "Select Course";
            this.Statuscmb.ValueMember = "CourseId";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(638, 370);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(57, 24);
            this.StatusLbl.TabIndex = 46;
            this.StatusLbl.Text = "Status";
            // 
            // StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 752);
            this.Controls.Add(this.Statuscmb);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SemesterCmb);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.GenderCmb);
            this.Controls.Add(this.CourseCmb);
            this.Controls.Add(this.Postaltxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.CellNTxt);
            this.Controls.Add(this.StudentRegTxt);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.PostalLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.CellLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.RegistraNumLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentEdit";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.StudentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SemesterCmb;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox GenderCmb;
        private System.Windows.Forms.ComboBox CourseCmb;
        private System.Windows.Forms.RichTextBox Postaltxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.TextBox CellNTxt;
        private System.Windows.Forms.TextBox StudentRegTxt;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.Label PostalLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label CellLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label RegistraNumLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Statuscmb;
        private System.Windows.Forms.Label StatusLbl;
    }
}