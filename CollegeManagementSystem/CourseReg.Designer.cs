namespace CollegeManagementSystem
{
    partial class CourseReg
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
            this.CourseID = new System.Windows.Forms.Label();
            this.CourseCodelbl = new System.Windows.Forms.Label();
            this.CourseNamelbl = new System.Windows.Forms.Label();
            this.CourseDlbl = new System.Windows.Forms.Label();
            this.CourseRegtxt = new System.Windows.Forms.TextBox();
            this.CourseCtxt = new System.Windows.Forms.TextBox();
            this.CourseNtxt = new System.Windows.Forms.TextBox();
            this.CourseDtxt = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(57, 64);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(146, 17);
            this.CourseID.TabIndex = 0;
            this.CourseID.Text = "CourseRegistration ID";
            // 
            // CourseCodelbl
            // 
            this.CourseCodelbl.AutoSize = true;
            this.CourseCodelbl.Location = new System.Drawing.Point(47, 154);
            this.CourseCodelbl.Name = "CourseCodelbl";
            this.CourseCodelbl.Size = new System.Drawing.Size(90, 17);
            this.CourseCodelbl.TabIndex = 1;
            this.CourseCodelbl.Text = "Course Code";
            // 
            // CourseNamelbl
            // 
            this.CourseNamelbl.AutoSize = true;
            this.CourseNamelbl.Location = new System.Drawing.Point(47, 248);
            this.CourseNamelbl.Name = "CourseNamelbl";
            this.CourseNamelbl.Size = new System.Drawing.Size(94, 17);
            this.CourseNamelbl.TabIndex = 2;
            this.CourseNamelbl.Text = "Course Name";
            // 
            // CourseDlbl
            // 
            this.CourseDlbl.AutoSize = true;
            this.CourseDlbl.Location = new System.Drawing.Point(47, 339);
            this.CourseDlbl.Name = "CourseDlbl";
            this.CourseDlbl.Size = new System.Drawing.Size(111, 17);
            this.CourseDlbl.TabIndex = 3;
            this.CourseDlbl.Text = "Course Duration";
            // 
            // CourseRegtxt
            // 
            this.CourseRegtxt.Location = new System.Drawing.Point(347, 64);
            this.CourseRegtxt.Name = "CourseRegtxt";
            this.CourseRegtxt.ReadOnly = true;
            this.CourseRegtxt.Size = new System.Drawing.Size(300, 22);
            this.CourseRegtxt.TabIndex = 1;
            // 
            // CourseCtxt
            // 
            this.CourseCtxt.Location = new System.Drawing.Point(347, 149);
            this.CourseCtxt.Name = "CourseCtxt";
            this.CourseCtxt.Size = new System.Drawing.Size(300, 22);
            this.CourseCtxt.TabIndex = 2;
            // 
            // CourseNtxt
            // 
            this.CourseNtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CourseNtxt.Location = new System.Drawing.Point(347, 243);
            this.CourseNtxt.Name = "CourseNtxt";
            this.CourseNtxt.Size = new System.Drawing.Size(300, 22);
            this.CourseNtxt.TabIndex = 3;
            // 
            // CourseDtxt
            // 
            this.CourseDtxt.Location = new System.Drawing.Point(347, 334);
            this.CourseDtxt.Name = "CourseDtxt";
            this.CourseDtxt.Size = new System.Drawing.Size(300, 22);
            this.CourseDtxt.TabIndex = 4;
            this.CourseDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(233, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(285, 32);
            this.TitleLbl.TabIndex = 84;
            this.TitleLbl.Text = "Course Registration";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(370, 382);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(125, 45);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(522, 382);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(125, 45);
            this.Closebtn.TabIndex = 6;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // CourseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.CourseDtxt);
            this.Controls.Add(this.CourseNtxt);
            this.Controls.Add(this.CourseCtxt);
            this.Controls.Add(this.CourseRegtxt);
            this.Controls.Add(this.CourseDlbl);
            this.Controls.Add(this.CourseNamelbl);
            this.Controls.Add(this.CourseCodelbl);
            this.Controls.Add(this.CourseID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseReg";
            this.Text = "CourseReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.Label CourseCodelbl;
        private System.Windows.Forms.Label CourseNamelbl;
        private System.Windows.Forms.Label CourseDlbl;
        private System.Windows.Forms.TextBox CourseRegtxt;
        private System.Windows.Forms.TextBox CourseCtxt;
        private System.Windows.Forms.TextBox CourseNtxt;
        private System.Windows.Forms.TextBox CourseDtxt;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Closebtn;
    }
}