using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Activity_Tracker
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password = ";
        MySqlConnection connection = new MySqlConnection(DBconnection);
        MySqlCommand command;
        MySqlDataReader mdr;

        private void Login_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM student_activity_tracker.login_info WHERE Username = '" + txtUserName.Text + 
                                 "' AND Password = '" + txtPassword.Text + "';";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                new Frm_Main().Show();
                this.Hide();             
            }
            else
            {
                MessageBox.Show("Incorrect Login Information! Try again.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

            connection.Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Redirect_Click(object sender, EventArgs e)
        {
            new StudentViewer().Show();
            this.Hide();
        }
    }
}
