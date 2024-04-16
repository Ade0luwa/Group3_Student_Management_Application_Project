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
            this.view_stat101_grade_button = new System.Windows.Forms.Button();
            this.view_math101_grade_button = new System.Windows.Forms.Button();
            this.stat_picture = new System.Windows.Forms.PictureBox();
            this.math_picture = new System.Windows.Forms.PictureBox();
            this.stat_label = new System.Windows.Forms.Label();
            this.math_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notification_label = new System.Windows.Forms.Label();
            this.logout_label = new System.Windows.Forms.Label();
            this.grades_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courses_label = new System.Windows.Forms.Label();
            this.dashboard_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.math_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view_stat101_grade_button
            // 
            this.view_stat101_grade_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_stat101_grade_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_stat101_grade_button.Location = new System.Drawing.Point(1120, 569);
            this.view_stat101_grade_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view_stat101_grade_button.Name = "view_stat101_grade_button";
            this.view_stat101_grade_button.Size = new System.Drawing.Size(248, 105);
            this.view_stat101_grade_button.TabIndex = 37;
            this.view_stat101_grade_button.Text = "Enter Students Grade";
            this.view_stat101_grade_button.UseVisualStyleBackColor = false;
            // 
            // view_math101_grade_button
            // 
            this.view_math101_grade_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_math101_grade_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_math101_grade_button.Location = new System.Drawing.Point(1120, 191);
            this.view_math101_grade_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view_math101_grade_button.Name = "view_math101_grade_button";
            this.view_math101_grade_button.Size = new System.Drawing.Size(248, 105);
            this.view_math101_grade_button.TabIndex = 36;
            this.view_math101_grade_button.Text = "Enter Students Grade";
            this.view_math101_grade_button.UseVisualStyleBackColor = false;
            // 
            // stat_picture
            // 
            this.stat_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stat_picture.BackgroundImage")));
            this.stat_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stat_picture.Location = new System.Drawing.Point(495, 497);
            this.stat_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stat_picture.Name = "stat_picture";
            this.stat_picture.Size = new System.Drawing.Size(580, 242);
            this.stat_picture.TabIndex = 35;
            this.stat_picture.TabStop = false;
            // 
            // math_picture
            // 
            this.math_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("math_picture.BackgroundImage")));
            this.math_picture.Location = new System.Drawing.Point(495, 118);
            this.math_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.math_picture.Name = "math_picture";
            this.math_picture.Size = new System.Drawing.Size(574, 246);
            this.math_picture.TabIndex = 34;
            this.math_picture.TabStop = false;
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stat_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_label.Location = new System.Drawing.Point(678, 743);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(123, 32);
            this.stat_label.TabIndex = 33;
            this.stat_label.Text = "STAT101";
            // 
            // math_label
            // 
            this.math_label.AutoSize = true;
            this.math_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.math_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.math_label.Location = new System.Drawing.Point(678, 365);
            this.math_label.Name = "math_label";
            this.math_label.Size = new System.Drawing.Size(137, 32);
            this.math_label.TabIndex = 32;
            this.math_label.Text = "MATH101";
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
            this.logout_label.Location = new System.Drawing.Point(28, 735);
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
            this.grades_label.Location = new System.Drawing.Point(28, 525);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(99, 32);
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
            this.dashboard_label.Location = new System.Drawing.Point(28, 329);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(148, 32);
            this.dashboard_label.TabIndex = 16;
            this.dashboard_label.Text = "Dashboard";
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // ProfessorGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1629, 895);
            this.Controls.Add(this.view_stat101_grade_button);
            this.Controls.Add(this.view_math101_grade_button);
            this.Controls.Add(this.stat_picture);
            this.Controls.Add(this.math_picture);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.math_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfessorGrades";
            this.Text = "ProfessorGrades";
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.math_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_stat101_grade_button;
        private System.Windows.Forms.Button view_math101_grade_button;
        private System.Windows.Forms.PictureBox stat_picture;
        private System.Windows.Forms.PictureBox math_picture;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label math_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notification_label;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Label grades_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label courses_label;
        private System.Windows.Forms.Label dashboard_label;
    }
}