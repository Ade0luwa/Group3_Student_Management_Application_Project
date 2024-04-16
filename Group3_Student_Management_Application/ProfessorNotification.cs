using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Group3_Student_Management_Application
{
    public partial class ProfessorNotification : Form
    {
        private string firstName;
        public ProfessorNotification()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void notification_label_Click(object sender, EventArgs e)
        {

        }

        private void send_notification_btn_Click(object sender, EventArgs e)
        {
            string message = notification_textBox.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Open();

            String command = $"INSERT INTO Notification (NotificationMessage, Date)" +
            $"VALUES ('{message}', @date)";

            DateTime date = DateTime.Now;
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                cmd.Parameters.AddWithValue("@date", date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Congratulations you have been successfully sent an announcement to your students", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notification_textBox.Clear();
            }
        }

        private void courses_label_Click(object sender, EventArgs e)
        {
            ProfessorCourses professorCourses = new ProfessorCourses();
            professorCourses.Show();
            this.Hide();
        }

        private void grades_label_Click(object sender, EventArgs e)
        {
            ProfessorGrades professorGrades = new ProfessorGrades();
            professorGrades.Show();
            this.Hide();
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            notification_label.BackColor = Color.DarkSeaGreen;
            logout_label.BackColor = Color.Honeydew;
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            ProfessorDashboard dashboard = new ProfessorDashboard(firstName);
            dashboard.Show();
            this.Hide();

        }
    }
}
