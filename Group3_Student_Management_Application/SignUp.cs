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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void signUp_loginHere_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void signUp_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            string fname = signUp_firstName.Text;
            string lname = signUp_lastName.Text;
            string email = signUp_email.Text;
            string password = signUp_password.Text;
            string phone = signUp_phone.Text;
            string role = "";
            string appName = "Group 3 Student Management Portal";

            if (signUp_student.Checked)
            {
                role = "Student";
            }
            else if (signUp_prof.Checked)
            {
                role = "Professor";
            }
            else
            {
                MessageBox.Show("Please select a user role.");
                return;
            }

            String checkEmail = $"SELECT * FROM UserCredentials WHERE Email = '{email}'";

            using(SqlCommand checkUser =  new SqlCommand(checkEmail, conn))
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(checkUser);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"{email} already exists in the system");
                }
                else
                {
                    String command = $"INSERT INTO UserCredentials (FirstName, LastName, Role, Email, Password, Phone, DateCreated)" +
                        $"VALUES ('{fname}', '{lname}', '{role}', '{email}', '{password}', '{phone}', @date)";
                    DateTime date = DateTime.Now;
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Congratulations {fname} {lname}, you have been registered as a {role} on {appName}. You may proceed to login");

                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    } 
                }
            }

            
        }

        
    }
}
