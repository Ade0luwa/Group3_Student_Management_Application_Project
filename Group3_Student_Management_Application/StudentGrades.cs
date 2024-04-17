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

namespace Group3_Student_Management_Application
{
    public partial class StudentGrades : Form
    {
        private string firstName;
        private int userID;
        public StudentGrades(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void grades_label_Click(object sender, EventArgs e)
        {
            //studentgrades studentgrades = new studentgrades();
            //studentgrades.show();
            //this.Close();
        }

        private void courses_label_Click(object sender, EventArgs e)
        {
            StudentCourses course = new StudentCourses();
            course.Show();
            this.Hide();
        }

        private void notification_label_Click(object sender, EventArgs e)
        {
            // Change the backcolor of the label text to Honeydew\
            grades_label.BackColor = Color.DarkSeaGreen;
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
                        grades_label.BackColor = Color.Honeydew;
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

        private void view_math101_grade_button_Click(object sender, EventArgs e)
        {
            // Call a method to fetch and display Math 101 grades
            ViewGradesForCourse("Math101");
        }

        private void view_stat101_grade_button_Click(object sender, EventArgs e)
        {
            // Call a method to fetch and display Stat 101 grades
            ViewGradesForCourse("Stat101");
        }

        private void ViewGradesForCourse(string courseName)
        {
            try
            {
                conn.Open();

                // SQL query to retrieve the grade for the specified course and logged-in student
                string query = "SELECT Grades.Grade FROM Grades " +
                               "INNER JOIN Courses ON Grades.CourseID = Courses.CourseID " +
                               "WHERE Grades.UserID = @UserID AND Courses.CourseName = @CourseName";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@CourseName", courseName);

                    // Execute the query and get the grade for the specified course
                    object gradeObj = command.ExecuteScalar();

                    if (gradeObj != null && gradeObj != DBNull.Value)
                    {
                        // Convert the grade object to string
                        string grade = gradeObj.ToString();

                        // Display the grade in a message box
                        MessageBox.Show($"Your grade for {courseName}: {grade}", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No grade found for {courseName}", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            StudentDashboard dashboard = new StudentDashboard(userID, firstName);
            dashboard.Show();
            this.Hide();
        }
    }
}
