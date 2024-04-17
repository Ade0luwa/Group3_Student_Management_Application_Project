using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group3_Student_Management_Application
{
    public partial class Login : Form
    {
        private int loggedInUserID;
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");



        private void login_registerHere_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            String email = loginUsername.Text;
            String password = loginPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email or password field is empty!!! Please enter a valid value and try again");
                return;
            }

            try
            {
                conn.Open();

                // SQL query to retrieve UserID, FirstName, and Role based on email and password
                string query = "SELECT UserID, FirstName, Role FROM UserCredentials WHERE Email = @Email AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string role = reader.GetString(2);

                            // Store UserID in a class-level variable for future reference
                            loggedInUserID = userID;

                            // Show different dashboards based on the user's role
                            if (role == "Student")
                            {
                                StudentDashboard studentDashboard = new StudentDashboard(userID, firstName);
                                studentDashboard.Show();
                            }
                            else if (role == "Professor")
                            {
                                ProfessorDashboard professorDashboard = new ProfessorDashboard(firstName);
                                professorDashboard.Show();
                            }

                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPassword.Checked)
            {
                loginPassword.PasswordChar = '\0';
            }
            else
            {
                loginPassword.PasswordChar = '*';
            }
        }

    }
}
