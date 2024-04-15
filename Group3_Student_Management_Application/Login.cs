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

            if (email == null || password == null)
            {
                MessageBox.Show("Email or password field is empty!!! Please enter a valid value and try again");
            }
            else
            {

                try
                {
                    String command = $"SELECT * FROM UserCredentials WHERE Email = '{email}' AND Password = '{password}'";
                    SqlDataAdapter sda = new SqlDataAdapter(command, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        email = loginUsername.Text;
                        password = loginPassword.Text;

                        string role = dt.Rows[0]["Role"].ToString();

                        // Show different dashboards based on the user's role
                        if (role == "Student")
                        {
                            StudentDashboard studentDashboard = new StudentDashboard();
                            studentDashboard.Show();
                            this.Hide();
                        }
                        else if (role == "Professor")
                        {
                            ProfessorDashboard professorDashboard = new ProfessorDashboard();
                            professorDashboard.Show();
                            this.Hide();
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials");
                    }
                }

                catch
                {
                    MessageBox.Show("Error");
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(login_showPassword.Checked)
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
