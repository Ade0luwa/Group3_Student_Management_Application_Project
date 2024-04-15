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
    public partial class StudentDashboard : Form
    {
        private string firstName;
        public StudentDashboard(string firstName)
        {
            InitializeComponent();
            this.firstName = firstName;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ADEOLUWATOMIWA\MSSQLSERVER01;Initial Catalog=Group3StudentManagement;Integrated Security=True;");

        private void logout_label_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
            
        }

        private void courses_label_Click(object sender, EventArgs e)
        {
            //navigating to courses page
            StudentCourses course = new StudentCourses();
            course.Show();
            this.Hide();
        }

        private void grades_label_Click(object sender, EventArgs e)
        {
            //navigating to grades page
            StudentGrades studentGrades = new StudentGrades();
            studentGrades.Show();
            this.Close();
        }

        private void notification_label_Click(object sender, EventArgs e)
        {
            ProfessorNotification notification = new ProfessorNotification();
            notification.Show();
            this.Close();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            welcome_label.Text = $"Hello { firstName}!!!" ;
        }
    }
    }
