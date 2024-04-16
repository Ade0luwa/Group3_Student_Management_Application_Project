namespace Group3_Student_Management_Application
{
    partial class ProfessorNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorNotification));
            this.notification_label = new System.Windows.Forms.Label();
            this.logout_label = new System.Windows.Forms.Label();
            this.grades_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courses_label = new System.Windows.Forms.Label();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notification_textBox = new System.Windows.Forms.TextBox();
            this.send_notification_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification_label
            // 
            this.notification_label.AutoSize = true;
            this.notification_label.BackColor = System.Drawing.Color.Honeydew;
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
            this.grades_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grades_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grades_label.Location = new System.Drawing.Point(28, 525);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(99, 32);
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
            // notification_textBox
            // 
            this.notification_textBox.BackColor = System.Drawing.Color.Ivory;
            this.notification_textBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_textBox.Location = new System.Drawing.Point(364, 34);
            this.notification_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notification_textBox.MaxLength = 327670000;
            this.notification_textBox.Multiline = true;
            this.notification_textBox.Name = "notification_textBox";
            this.notification_textBox.Size = new System.Drawing.Size(1222, 692);
            this.notification_textBox.TabIndex = 30;
            // 
            // send_notification_btn
            // 
            this.send_notification_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.send_notification_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_notification_btn.Location = new System.Drawing.Point(868, 748);
            this.send_notification_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.send_notification_btn.Name = "send_notification_btn";
            this.send_notification_btn.Size = new System.Drawing.Size(248, 105);
            this.send_notification_btn.TabIndex = 31;
            this.send_notification_btn.Text = "Post Notification";
            this.send_notification_btn.UseVisualStyleBackColor = false;
            this.send_notification_btn.Click += new System.EventHandler(this.send_notification_btn_Click);
            // 
            // ProfessorNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1629, 895);
            this.Controls.Add(this.send_notification_btn);
            this.Controls.Add(this.notification_textBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfessorNotification";
            this.Text = "StudentNotification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox notification_textBox;
        private System.Windows.Forms.Button send_notification_btn;
    }
}