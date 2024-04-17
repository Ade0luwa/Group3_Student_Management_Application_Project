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
    public partial class ProfessorGrades : Form
    {
        private string firstName;
        public ProfessorGrades()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            ProfessorDashboard dashboard = new ProfessorDashboard(firstName);
            dashboard.Show();
            this.Hide();
        }

        private void courses_label_Click(object sender, EventArgs e)
        {
            ProfessorCourses professorCourses = new ProfessorCourses();
            professorCourses.Show();
            this.Hide();
        }

        private void notification_label_Click(object sender, EventArgs e)
        {
            ProfessorNotification notification = new ProfessorNotification();
            notification.Show();
            this.Close();
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            grades_label.BackColor = Color.DarkSeaGreen;
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

        private void courses_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected course name
            MessageBox.Show($"Selected Course Name: {courses_comboBox.SelectedItem}");
        }

        private void ProfessorGrades_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // Populate student ComboBox
                populateStudentComboBox();

                // Populate courses ComboBox
                populateCoursesComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void students_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected course name
            MessageBox.Show($"Selected Student Name: {students_comboBox.SelectedItem}");
        }

        private void populateStudentComboBox()
        {
            // Clear any existing items in the ComboBox
            students_comboBox.Items.Clear();

            // Query to select UserID, FirstName, and LastName from UserCredentials table for users with "Student" role
            string query = "SELECT UserID, FirstName, LastName FROM UserCredentials WHERE Role = 'Student'";

            // Execute the query
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Iterate through the results and add student names to the ComboBox
                    while (reader.Read())
                    {
                        // Get UserID, FirstName, and LastName
                        int userID = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);

                        // Concatenate first and last names to display full name
                        string fullName = $"{firstName} {lastName}";

                        // Add student name to the ComboBox
                        students_comboBox.Items.Add(fullName);
                    }
                }
            }
        }

        private void populateCoursesComboBox()
        {
            // Clear any existing items in the ComboBox
            courses_comboBox.Items.Clear();

            // Query to select CourseID and CourseName from the Courses table
            string query = "SELECT CourseID, CourseName FROM Courses";

            // Execute the query
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Iterate through the results and add course names to the ComboBox
                    while (reader.Read())
                    {
                        // Get the name of the course
                        string courseName = reader.GetString(1);

                        // Add course name to the ComboBox
                        courses_comboBox.Items.Add(courseName);
                    }
                }
            }
        }

        private void grade_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Check if the text is empty or not a positive integer
            if (!string.IsNullOrEmpty(text) && !IsPositiveInteger(text))
            {
                // If not a positive integer, clear the textbox
                textBox.Clear();
            }
        }
        private bool IsPositiveInteger(string text)
        {
            int value;
            return int.TryParse(text, out value) && value > 0;
        }

        private void submit_grade_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open(); // Open the connection if it's closed

                // Get the selected student and course from the ComboBoxes
                string selectedStudent = students_comboBox.SelectedItem?.ToString();
                string selectedCourse = courses_comboBox.SelectedItem?.ToString();

                // Get the entered grade from the textBox
                string gradeInput = grade_textBox.Text.Trim();

                // Validate if all required fields are selected/entered
                if (string.IsNullOrEmpty(selectedStudent) || string.IsNullOrEmpty(selectedCourse) || string.IsNullOrEmpty(gradeInput))
                {
                    MessageBox.Show("Please select a student, course, and enter a grade.");
                    return;
                }

                // Validate if the entered grade is a positive integer and not exceeding 100
                if (!IsPositiveInteger(gradeInput) || Convert.ToInt32(gradeInput) > 100)
                {
                    MessageBox.Show("Please enter a valid positive integer grade not exceeding 100.");
                    return;
                }

                // Convert student name to UserID by splitting and querying the database
                string[] studentNameParts = selectedStudent.Split(' ');
                int studentUserID = GetUserIDByName(studentNameParts[0], studentNameParts[1]);

                // Get CourseID by CourseName
                int courseID = GetCourseIDByName(selectedCourse);

                // Check if the record already exists in the Grades table
                bool recordExists = CheckRecordExists(studentUserID, courseID);

                if (recordExists)
                {
                    // Update the existing record
                    UpdateGrade(studentUserID, courseID, Convert.ToInt32(gradeInput));
                }
                else
                {
                    // Insert a new record
                    InsertGrade(studentUserID, courseID, Convert.ToInt32(gradeInput));
                }

                MessageBox.Show("Grade submitted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection if it's open
            }
        }

        // Helper method to check if a record exists in the Grades table for the given UserID and CourseID
        private bool CheckRecordExists(int userID, int courseID)
        {
            string query = "SELECT COUNT(*) FROM Grades WHERE UserID = @UserID AND CourseID = @CourseID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        // Helper method to update the grade in the Grades table
        private void UpdateGrade(int userID, int courseID, int grade)
        {
            string query = "UPDATE Grades SET Grade = @Grade WHERE UserID = @UserID AND CourseID = @CourseID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@Grade", grade);
                command.ExecuteNonQuery();
            }
        }

        // Helper method to insert a new grade into the Grades table
        private void InsertGrade(int userID, int courseID, int grade)
        {
            string query = "INSERT INTO Grades (UserID, CourseID, Grade) VALUES (@UserID, @CourseID, @Grade)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@Grade", grade);
                command.ExecuteNonQuery();
            }
        }


        // Helper method to retrieve UserID by FirstName and LastName
        private int GetUserIDByName(string firstName, string lastName)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open(); // Open the connection if it's closed

            string query = "SELECT UserID FROM UserCredentials WHERE FirstName = @FirstName AND LastName = @LastName";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        // Helper method to retrieve CourseID by CourseName
        private int GetCourseIDByName(string courseName)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open(); // Open the connection if it's closed

            string query = "SELECT CourseID FROM Courses WHERE CourseName = @CourseName";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CourseName", courseName);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }


    }
}