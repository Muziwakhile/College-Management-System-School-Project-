namespace CollegeManagementSystem
{
    partial class MainMenuFrm
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
            this.StudentBtn = new System.Windows.Forms.Button();
            this.ViewStudentBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.TeacherBtn = new System.Windows.Forms.Button();
            this.CourseBtn = new System.Windows.Forms.Button();
            this.ViewteacherBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentBtn
            // 
            this.StudentBtn.Location = new System.Drawing.Point(13, 70);
            this.StudentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(279, 177);
            this.StudentBtn.TabIndex = 0;
            this.StudentBtn.Text = "Register Students";
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // ViewStudentBtn
            // 
            this.ViewStudentBtn.Location = new System.Drawing.Point(414, 70);
            this.ViewStudentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewStudentBtn.Name = "ViewStudentBtn";
            this.ViewStudentBtn.Size = new System.Drawing.Size(279, 177);
            this.ViewStudentBtn.TabIndex = 1;
            this.ViewStudentBtn.Text = "View Students";
            this.ViewStudentBtn.UseVisualStyleBackColor = true;
            this.ViewStudentBtn.Click += new System.EventHandler(this.ViewStudentBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(839, 70);
            this.PaymentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(279, 177);
            this.PaymentBtn.TabIndex = 2;
            this.PaymentBtn.Text = "Student Payments";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.Location = new System.Drawing.Point(13, 391);
            this.TeacherBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.Size = new System.Drawing.Size(279, 177);
            this.TeacherBtn.TabIndex = 3;
            this.TeacherBtn.Text = "Register Teachers";
            this.TeacherBtn.UseVisualStyleBackColor = true;
            this.TeacherBtn.Click += new System.EventHandler(this.TeacherBtn_Click);
            // 
            // CourseBtn
            // 
            this.CourseBtn.Location = new System.Drawing.Point(839, 391);
            this.CourseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseBtn.Name = "CourseBtn";
            this.CourseBtn.Size = new System.Drawing.Size(279, 177);
            this.CourseBtn.TabIndex = 4;
            this.CourseBtn.Text = "Administration";
            this.CourseBtn.UseVisualStyleBackColor = true;
            this.CourseBtn.Click += new System.EventHandler(this.CourseBtn_Click);
            // 
            // ViewteacherBtn
            // 
            this.ViewteacherBtn.Location = new System.Drawing.Point(414, 391);
            this.ViewteacherBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewteacherBtn.Name = "ViewteacherBtn";
            this.ViewteacherBtn.Size = new System.Drawing.Size(279, 177);
            this.ViewteacherBtn.TabIndex = 5;
            this.ViewteacherBtn.Text = "View Teachers";
            this.ViewteacherBtn.UseVisualStyleBackColor = true;
            this.ViewteacherBtn.Click += new System.EventHandler(this.ViewteacherBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(312, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(578, 32);
            this.TitleLbl.TabIndex = 6;
            this.TitleLbl.Text = "College Management System Tools Menu";
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 591);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ViewteacherBtn);
            this.Controls.Add(this.CourseBtn);
            this.Controls.Add(this.TeacherBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.ViewStudentBtn);
            this.Controls.Add(this.StudentBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Button ViewStudentBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button TeacherBtn;
        private System.Windows.Forms.Button CourseBtn;
        private System.Windows.Forms.Button ViewteacherBtn;
        private System.Windows.Forms.Label TitleLbl;
    }
}