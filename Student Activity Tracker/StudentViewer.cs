using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Activity_Tracker
{
    public partial class StudentViewer : Form
    {
        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password = ";

        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        MySqlConnection connection2 = new MySqlConnection(DBconnection);
        DataTable dtRecords2 = new DataTable();
        MySqlCommand command2;
        MySqlDataReader mdr2;

        public StudentViewer()
        {
            InitializeComponent();
            UpcomingEventsTable();
            TotalPointsAccumulator();
        }

        private void UpcomingEventsTable()
        {
            string myDate;

            try
            {
                connection.Open();

                DateTime TheDate = DateTime.Now;
                var _dateString = TheDate.ToString("yyyy-MM-dd");
                myDate = _dateString;

                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT `EventName`, `Date` " +
                    "FROM student_activity_tracker.event_info " +
                    "WHERE `Date` >  \"" + myDate + "\"";

                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                UpcomingEvents.DataSource = dtRecords;

                connection.Close();

                var dateString = TheDate.ToString("MMMM dd, yyyy (ddd)");
                Date.Text = dateString;
            }
            catch
            {
                MessageBox.Show("Sorting out request...");
            }
        }
        private void PreviousActivities()
        {
            dtRecords2.Rows.Clear();
            AttendanceTable.Refresh();

            connection2.Open();

            command2 = connection2.CreateCommand();
            command2.CommandText =
                "SELECT EventName, Points, Date " +
                "FROM student_activity_tracker.event_info " +
                "JOIN student_activity_tracker.attendance " +
                "ON event_info.EventID = attendance.eventID " +
                "WHERE attendance.studentID = " + TxtSearch.Text;

            mdr2 = command2.ExecuteReader();
            dtRecords2.Load(mdr2);
            AttendanceTable.DataSource = dtRecords2;

            connection2.Close();
        }
        private void ViewTotalPoints()
        {
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText =
                "SELECT TotalPoints " +
                "FROM student_activity_tracker.student_info " +
                "WHERE ID = '" + TxtSearch.Text + "'";

            mdr = command.ExecuteReader();
            mdr.Read();
            LblTotalPoints.Text = mdr["TotalPoints"].ToString();
            connection.Close();
        }
        private void GetFirstName()
        {
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText =
                "SELECT Forename " +
                "FROM student_activity_tracker.student_info " +
                "WHERE ID = '" + TxtSearch.Text + "'";

            mdr = command.ExecuteReader();
            mdr.Read();
            LblGreeting.Text = "Hello, " + mdr["Forename"].ToString() + "!";
            connection.Close();
        }
        private void TotalPointsAccumulator()
        {
            int count;
            int TotalPoints = 0;

            DateTime _date = DateTime.Now;
            var _dateString = _date.ToString("yyyy-MM-dd");
            string myDate = _dateString;

            connection.Open();

            command = connection.CreateCommand();
            command.CommandText =
                "SELECT COUNT(POINTS) " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` <  \"" + myDate + "\"";

            mdr = command.ExecuteReader();
            mdr.Read();
            count = Convert.ToInt32(mdr["COUNT(POINTS)"]);

            connection.Close();


            for (int i = 0; i < count; i++)
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT `POINTS` " +
                    "FROM student_activity_tracker.event_info " +
                    "WHERE `Date` <  \"" + myDate + "\"";

                mdr = command.ExecuteReader();
                mdr.Read();
                TotalPoints += Convert.ToInt32(mdr["POINTS"]);

                connection.Close();
            }

            LblTotalPoints2.Text = "TOTAL POINTS : " + TotalPoints.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TxtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            LineSearch.Visible = true;
            TxtSearch.BackColor = Color.FromArgb(139, 199, 255);
            PnlSearch.BackColor = Color.FromArgb(139, 199, 255);
        }
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            LineSearch.Visible = false;
            TxtSearch.BackColor = Color.FromArgb(99, 180, 255);
            PnlSearch.BackColor = Color.FromArgb(99, 180, 255);
        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT ID " +
                                 "FROM student_activity_tracker.student_info " +
                                 "WHERE ID = \"" + TxtSearch.Text + "\"";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                panelFillPage.Visible = true;
                connection.Close();
                PreviousActivities();
                ViewTotalPoints();
                GetFirstName();
            }
            else
            {
                MessageBox.Show("Student Not Found.");
                panelFillPage.Visible = false;
            }

            connection.Close();
        }
        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Return To Login Page?", "NOTICE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}
