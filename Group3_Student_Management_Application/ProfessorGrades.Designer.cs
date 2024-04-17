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
            this.submit_grade_button.Location = new System.Drawing.Point(1058, 382);
            this.submit_grade_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submit_grade_button.Name = "submit_grade_button";
            this.submit_grade_button.Size = new System.Drawing.Size(186, 78);
            this.submit_grade_button.TabIndex = 37;
            this.submit_grade_button.Text = "Submit";
            this.submit_grade_button.UseVisualStyleBackColor = false;
            this.submit_grade_button.Click += new System.EventHandler(this.submit_grade_button_Click);
            // 
            // stat_picture
            // 
            this.stat_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stat_picture.BackgroundImage")));
            this.stat_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stat_picture.Location = new System.Drawing.Point(326, 469);
            this.stat_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stat_picture.Name = "stat_picture";
            this.stat_picture.Size = new System.Drawing.Size(672, 392);
            this.stat_picture.TabIndex = 35;
            this.stat_picture.TabStop = false;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(564, 142);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(133, 42);
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
            this.panel1.Location = new System.Drawing.Point(32, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 828);
            this.panel1.TabIndex = 31;
            // 
            // notification_label
            // 
            this.notification_label.AutoSize = true;
            this.notification_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notification_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_label.Location = new System.Drawing.Point(28, 632);
            this.notification_label.Name = "notification_label";
            this.notification_label.Size = new System.Drawing.Size(242, 48);
            this.notification_label.TabIndex = 19;
            this.notification_label.Text = "Notification";
            this.notification_label.Click += new System.EventHandler(this.notification_label_Click);
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.Location = new System.Drawing.Point(28, 735);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(149, 48);
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
            this.grades_label.Location = new System.Drawing.Point(28, 525);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(152, 48);
            this.grades_label.TabIndex = 18;
            this.grades_label.Text = "Grades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 277);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // courses_label
            // 
            this.courses_label.AutoSize = true;
            this.courses_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courses_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_label.Location = new System.Drawing.Point(28, 428);
            this.courses_label.Name = "courses_label";
            this.courses_label.Size = new System.Drawing.Size(170, 48);
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
            this.dashboard_label.Location = new System.Drawing.Point(28, 329);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(225, 48);
            this.dashboard_label.TabIndex = 16;
            this.dashboard_label.Text = "Dashboard";
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // courses_comboBox
            // 
            this.courses_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courses_comboBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_comboBox.FormattingEnabled = true;
            this.courses_comboBox.Location = new System.Drawing.Point(770, 135);
            this.courses_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courses_comboBox.Name = "courses_comboBox";
            this.courses_comboBox.Size = new System.Drawing.Size(472, 44);
            this.courses_comboBox.TabIndex = 38;
            this.courses_comboBox.SelectedIndexChanged += new System.EventHandler(this.courses_comboBox_SelectedIndexChanged);
            // 
            // students_comboBox
            // 
            this.students_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.students_comboBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students_comboBox.FormattingEnabled = true;
            this.students_comboBox.Location = new System.Drawing.Point(770, 229);
            this.students_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.students_comboBox.Name = "students_comboBox";
            this.students_comboBox.Size = new System.Drawing.Size(472, 44);
            this.students_comboBox.TabIndex = 39;
            this.students_comboBox.SelectedIndexChanged += new System.EventHandler(this.students_comboBox_SelectedIndexChanged);
            // 
            // grade_textBox
            // 
            this.grade_textBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_textBox.Location = new System.Drawing.Point(770, 323);
            this.grade_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grade_textBox.Name = "grade_textBox";
            this.grade_textBox.Size = new System.Drawing.Size(249, 43);
            this.grade_textBox.TabIndex = 40;
            this.grade_textBox.TextChanged += new System.EventHandler(this.grade_textBox_TextChanged);
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_label.Location = new System.Drawing.Point(564, 325);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(116, 42);
            this.grade_label.TabIndex = 41;
            this.grade_label.Text = "Grade";
            // 
            // student_label
            // 
            this.student_label.AutoSize = true;
            this.student_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_label.Location = new System.Drawing.Point(564, 235);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(145, 42);
            this.student_label.TabIndex = 42;
            this.student_label.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(957, 469);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(672, 392);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // ProfessorGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1629, 895);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfessorGrades";
            this.Text = "ProfessorGrades";
            this.Load += new System.EventHandler(this.ProfessorGrades_Load);
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