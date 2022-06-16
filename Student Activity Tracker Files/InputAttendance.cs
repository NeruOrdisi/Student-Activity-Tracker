using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Activity_Tracker
{
    public partial class InputAttendance : Form
    {
        int eventID;
        int studentID;

        public InputAttendance()
        {
            InitializeComponent();
        }

        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password =; Convert Zero Datetime=True";
        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        private void ClearTable()
        {
            dtRecords.Rows.Clear();
            DGVUser.Refresh();
            TxtAttendance.Text = " ";
        }
        private void SubmitAttendance()
        {
            connection.Open();

            string selectQuery = 
                "SELECT COUNT(attendanceID) " +
                "FROM student_activity_tracker.attendance " +
                "WHERE studentID = \"" + studentID.ToString() + "\"" +
                "AND eventID = \"" + eventID.ToString() + "\"";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            mdr.Read();

            if (Convert.ToInt32(mdr["COUNT(attendanceID)"]) == 0)
            {
                connection.Close();
                connection.Open();

                selectQuery = "INSERT INTO student_activity_tracker.attendance " +
                              "(eventID, studentID) " +
                              "VALUES ( \"" + eventID + "\", \"" + studentID + "\")";

                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DGVUser.DataSource = dtRecords;

                connection.Close();
                UpdatePoints();
            }
            else
            {
                MessageBox.Show("Student Is Already Present");
            }
        }
        private void UpdatePoints()
        {
            int studentPoints, eventPoints, totalPoints;

            // Gets the total points of the student
            connection.Open();
            string selectQuery =
                "SELECT TotalPoints " +
                "FROM student_activity_tracker.student_info " +
                "WHERE ID = \"" + studentID + "\"";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            mdr.Read();
            studentPoints = Convert.ToInt32(mdr["TotalPoints"]);
            connection.Close();

            // Gets the corresponding points of the event
            connection.Open();
            selectQuery = "SELECT Points " +
                          "FROM student_activity_tracker.event_info " +
                          "WHERE EventID = \"" + eventID + "\"";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            mdr.Read();
            eventPoints = Convert.ToInt32(mdr["Points"]);
            connection.Close();


            totalPoints = studentPoints + eventPoints;


            // Update the points of the student
            connection.Open();
            selectQuery = "UPDATE student_activity_tracker.student_info " +
                          "SET TotalPoints = '" + totalPoints.ToString() + "' " +
                          "WHERE ID = \"" + studentID + "\"";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();        
            connection.Close();
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            PnlSearch.BackColor = Color.FromArgb(139, 199, 255);
            TxtSearch.BackColor = Color.FromArgb(139, 199, 255);
            LineSearch.Visible = true;
        }
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            PnlSearch.BackColor = Color.FromArgb(99, 180, 255);
            TxtSearch.BackColor = Color.FromArgb(99, 180, 255);
            LineSearch.Visible = false;
       }
        private void TxtAttendance_Click(object sender, EventArgs e)
        {
            panelAttendance.BackColor = Color.FromArgb(139, 199, 255);
            TxtAttendance.BackColor = Color.FromArgb(139, 199, 255);
            LineSearch2.Visible = true;
        }
        private void PanelAttendance_Leave(object sender, EventArgs e)
        {
            panelAttendance.BackColor = Color.FromArgb(99, 180, 255);
            TxtAttendance.BackColor = Color.FromArgb(99, 180, 255);
            LineSearch2.Visible = false;
        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            ClearTable();
            DateTime _date = DateTime.Now;
            var myDate = _date.ToString("M/d/yyyy");

            string[] separator;
            string eventDate;
            string access = "NO";

            connection.Open();

            string selectQuery = "SELECT EventID, Date FROM student_activity_tracker.event_info " +
                                 "WHERE EventID = \"" + TxtSearch.Text + "\"";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                separator = mdr["Date"].ToString().Split(' ');
                eventDate = separator[0];

                LblEventDate.Visible = true;
                LblEventDate.Text = eventDate;

                access = eventDate == myDate ? "Yes" : "NO";

                if (access == "Yes")
                {
                    eventID = Convert.ToInt32(mdr["EventID"]);
                    LblAccess.Text = "Yes";
                    PnlAttendanceFiller.Visible = true;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("The date of the event does not match the current date");
                    PnlAttendanceFiller.Visible = false;
                    DGVPanel.Visible = false;
                    LblAccess.Text = "NO";
                }
            } 
            else
            {
                LblAccess.Text = "NO";
                DGVPanel.Visible = false;
                LblEventDate.Visible = false;
                PnlAttendanceFiller.Visible = false;
                MessageBox.Show("Event does not exist.");
            }

            connection.Close();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string selectQuery;
            string myDate;

            DGVPanel.Visible = true;
            studentID = Convert.ToInt32(TxtAttendance.Text);

            DateTime _date = DateTime.Now;
            var _dateString = _date.ToString("yyyy-MM-dd");
            myDate = _dateString;

            // Show to DataGridView
            connection.Open();

            selectQuery = "SELECT ID AS SchoolID " +
                          "FROM student_activity_tracker.student_info " +
                          "ORDER BY ID DESC LIMIT 1";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            mdr.Read();

            if(Convert.ToInt32(mdr["SchoolID"]) >=  studentID)
            {
                connection.Close();
                connection.Open();

                selectQuery = "SELECT ID, Forename, Surname, Course, YearLevel " +
                              "FROM student_activity_tracker.student_info " +
                              "WHERE ID = \"" + studentID.ToString() + "\"";

                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DGVUser.DataSource = dtRecords;

                connection.Close();
                SubmitAttendance();
            } 
            else
            {
                MessageBox.Show("Student Not Found.");
            }         
            connection.Close();
        }
    }
}
