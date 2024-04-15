namespace Group3_Student_Management_Application
{
    partial class StudentCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCourses));
            this.notification_label = new System.Windows.Forms.Label();
            this.logout_label = new System.Windows.Forms.Label();
            this.grades_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courses_label = new System.Windows.Forms.Label();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.stat_picture = new System.Windows.Forms.PictureBox();
            this.math_picture = new System.Windows.Forms.PictureBox();
            this.stat_label = new System.Windows.Forms.Label();
            this.math_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.math_picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grades_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grades_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grades_label.Location = new System.Drawing.Point(28, 525);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(152, 48);
            this.grades_label.TabIndex = 18;
            this.grades_label.Text = "Grades";
            this.grades_label.Click += new System.EventHandler(this.grades_label_Click);
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
            this.courses_label.BackColor = System.Drawing.Color.Honeydew;
            this.courses_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courses_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_label.Location = new System.Drawing.Point(28, 428);
            this.courses_label.Name = "courses_label";
            this.courses_label.Size = new System.Drawing.Size(170, 48);
            this.courses_label.TabIndex = 15;
            this.courses_label.Text = "Courses";
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
            // stat_picture
            // 
            this.stat_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stat_picture.BackgroundImage")));
            this.stat_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stat_picture.Location = new System.Drawing.Point(992, 511);
            this.stat_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stat_picture.Name = "stat_picture";
            this.stat_picture.Size = new System.Drawing.Size(580, 242);
            this.stat_picture.TabIndex = 28;
            this.stat_picture.TabStop = false;
            // 
            // math_picture
            // 
            this.math_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("math_picture.BackgroundImage")));
            this.math_picture.Location = new System.Drawing.Point(380, 100);
            this.math_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.math_picture.Name = "math_picture";
            this.math_picture.Size = new System.Drawing.Size(574, 246);
            this.math_picture.TabIndex = 27;
            this.math_picture.TabStop = false;
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stat_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_label.Location = new System.Drawing.Point(1203, 757);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(183, 48);
            this.stat_label.TabIndex = 26;
            this.stat_label.Text = "STAT101";
            // 
            // math_label
            // 
            this.math_label.AutoSize = true;
            this.math_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.math_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.math_label.Location = new System.Drawing.Point(561, 351);
            this.math_label.Name = "math_label";
            this.math_label.Size = new System.Drawing.Size(207, 48);
            this.math_label.TabIndex = 25;
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
            this.panel1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(380, 451);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 327670000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 409);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Ivory;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(998, 100);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.MaxLength = 327670000;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(572, 338);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1546, 831);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1629, 895);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stat_picture);
            this.Controls.Add(this.math_picture);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.math_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentCourses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.math_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notification_label;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Label grades_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label courses_label;
        private System.Windows.Forms.Label dashboard_label;
        private System.Windows.Forms.PictureBox stat_picture;
        private System.Windows.Forms.PictureBox math_picture;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label math_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}