namespace Group3_Student_Management_Application
{
    partial class ProfessorGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorGrades));
            this.submit_grade_button = new System.Windows.Forms.Button();
            this.stat_picture = new System.Windows.Forms.PictureBox();
            this.course_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notification_label = new System.Windows.Forms.Label();
            this.logout_label = new System.Windows.Forms.Label();
            this.grades_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courses_label = new System.Windows.Forms.Label();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.courses_comboBox = new System.Windows.Forms.ComboBox();
            this.students_comboBox = new System.Windows.Forms.ComboBox();
            this.grade_textBox = new System.Windows.Forms.TextBox();
            this.grade_label = new System.Windows.Forms.Label();
            this.student_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_grade_button
            // 
            this.submit_grade_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submit_grade_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_grade_button.Location = new System.Drawing.Point(705, 248);
            this.submit_grade_button.Name = "submit_grade_button";
            this.submit_grade_button.Size = new System.Drawing.Size(124, 51);
            this.submit_grade_button.TabIndex = 37;
            this.submit_grade_button.Text = "Submit";
            this.submit_grade_button.UseVisualStyleBackColor = false;
            // 
            // stat_picture
            // 
            this.stat_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stat_picture.BackgroundImage")));
            this.stat_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stat_picture.Location = new System.Drawing.Point(217, 305);
            this.stat_picture.Name = "stat_picture";
            this.stat_picture.Size = new System.Drawing.Size(448, 255);
            this.stat_picture.TabIndex = 35;
            this.stat_picture.TabStop = false;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(376, 92);
            this.course_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(89, 28);
            this.course_label.TabIndex = 33;
            this.course_label.Text = "Course";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.notification_label);
            this.panel1.Controls.Add(this.logout_label);
            this.panel1.Controls.Add(this.grades_label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.courses_label);
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 538);
            this.panel1.TabIndex = 31;
            // 
            // notification_label
            // 
            this.notification_label.AutoSize = true;
            this.notification_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notification_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_label.Location = new System.Drawing.Point(19, 411);
            this.notification_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notification_label.Name = "notification_label";
            this.notification_label.Size = new System.Drawing.Size(158, 32);
            this.notification_label.TabIndex = 19;
            this.notification_label.Text = "Notification";
            this.notification_label.Click += new System.EventHandler(this.notification_label_Click);
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.Location = new System.Drawing.Point(19, 478);
            this.logout_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(99, 32);
            this.logout_label.TabIndex = 11;
            this.logout_label.Text = "Logout";
            this.logout_label.Click += new System.EventHandler(this.logout_label_Click);
            // 
            // grades_label
            // 
            this.grades_label.AutoSize = true;
            this.grades_label.BackColor = System.Drawing.Color.Honeydew;
            this.grades_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grades_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grades_label.Location = new System.Drawing.Point(19, 341);
            this.grades_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(99, 32);
            this.grades_label.TabIndex = 18;
            this.grades_label.Text = "Grades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 180);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // courses_label
            // 
            this.courses_label.AutoSize = true;
            this.courses_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courses_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_label.Location = new System.Drawing.Point(19, 278);
            this.courses_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courses_label.Name = "courses_label";
            this.courses_label.Size = new System.Drawing.Size(110, 32);
            this.courses_label.TabIndex = 15;
            this.courses_label.Text = "Courses";
            this.courses_label.Click += new System.EventHandler(this.courses_label_Click);
            // 
            // dashboard_label
            // 
            this.dashboard_label.AutoSize = true;
            this.dashboard_label.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboard_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label.Location = new System.Drawing.Point(19, 214);
            this.dashboard_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(148, 32);
            this.dashboard_label.TabIndex = 16;
            this.dashboard_label.Text = "Dashboard";
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // courses_comboBox
            // 
            this.courses_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_comboBox.FormattingEnabled = true;
            this.courses_comboBox.Location = new System.Drawing.Point(513, 88);
            this.courses_comboBox.Name = "courses_comboBox";
            this.courses_comboBox.Size = new System.Drawing.Size(316, 32);
            this.courses_comboBox.TabIndex = 38;
            // 
            // students_comboBox
            // 
            this.students_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students_comboBox.FormattingEnabled = true;
            this.students_comboBox.Location = new System.Drawing.Point(513, 149);
            this.students_comboBox.Name = "students_comboBox";
            this.students_comboBox.Size = new System.Drawing.Size(316, 32);
            this.students_comboBox.TabIndex = 39;
            // 
            // grade_textBox
            // 
            this.grade_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_textBox.Location = new System.Drawing.Point(513, 210);
            this.grade_textBox.Name = "grade_textBox";
            this.grade_textBox.Size = new System.Drawing.Size(112, 29);
            this.grade_textBox.TabIndex = 40;
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_label.Location = new System.Drawing.Point(376, 211);
            this.grade_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(79, 28);
            this.grade_label.TabIndex = 41;
            this.grade_label.Text = "Grade";
            // 
            // student_label
            // 
            this.student_label.AutoSize = true;
            this.student_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_label.Location = new System.Drawing.Point(376, 153);
            this.student_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(97, 28);
            this.student_label.TabIndex = 42;
            this.student_label.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(638, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(448, 255);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // ProfessorGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1086, 582);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.student_label);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.grade_textBox);
            this.Controls.Add(this.students_comboBox);
            this.Controls.Add(this.courses_comboBox);
            this.Controls.Add(this.submit_grade_button);
            this.Controls.Add(this.stat_picture);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfessorGrades";
            this.Text = "ProfessorGrades";
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_grade_button;
        private System.Windows.Forms.PictureBox stat_picture;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notification_label;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Label grades_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label courses_label;
        private System.Windows.Forms.Label dashboard_label;
        private System.Windows.Forms.ComboBox courses_comboBox;
        private System.Windows.Forms.ComboBox students_comboBox;
        private System.Windows.Forms.TextBox grade_textBox;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Label student_label;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}