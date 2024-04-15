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

namespace Group3_Student_Management_Application
{
    public partial class StudentCourses : Form
    {
        public StudentCourses()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void grades_label_Click(object sender, EventArgs e)
        {
            StudentGrades studentGrades = new StudentGrades();
            studentGrades.Show();
            this.Close();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
           
        }

        private void notification_label_Click(object sender, EventArgs e)
        {
            // Change the backcolor of the label text to Honeydew
            courses_label.BackColor = Color.DarkSeaGreen;
            notification_label.BackColor = Color.Honeydew;
            DisplayNotificationMessage();
        }

        private void DisplayNotificationMessage()
        {
            conn.Open();

            // SQL query to retrieve the latest notification message
            string query = "SELECT TOP 1 NotificationMessage FROM Notification ORDER BY Date DESC";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Retrieve the notification message
                        string notificationMessage = reader["NotificationMessage"].ToString();

                        // Display the notification message in a message box
                        MessageBox.Show(notificationMessage, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        courses_label.BackColor = Color.Honeydew;
                        notification_label.BackColor = Color.DarkSeaGreen;
                    }
                    else
                    {
                        MessageBox.Show("No notification found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            conn.Close();
        }


        private void logout_label_Click(object sender, EventArgs e)
        {
            dashboard_label.BackColor = Color.DarkSeaGreen;
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
    }
}
