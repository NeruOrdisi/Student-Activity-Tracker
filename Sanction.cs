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
    public partial class Sanction : Form
    {
        string course;
        string yeardate = "2022";
        string date;
        string eventID;
        string choice;
        int indexRow;

        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password =; Convert Zero Datetime=True";

        // Load Table for MONTHLY AND QUARTERLY
        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        DataTable studentRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        // Load Student Table
        MySqlConnection connection2 = new MySqlConnection(DBconnection);
        DataTable dtRecords2 = new DataTable();
        MySqlCommand command2;
        MySqlDataReader mdr2;

        // Load Table for YEARLY 
        MySqlConnection connection3 = new MySqlConnection(DBconnection);
        DataTable dtRecords3 = new DataTable();
        MySqlCommand command3;
        MySqlDataReader mdr3;

        public Sanction()
        {
            InitializeComponent();

            DGVEvent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVEvent.MultiSelect = false;

            DGVStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVStudent.MultiSelect = false;
        }

        private void ClearEventTable()
        {
            dtRecords.Rows.Clear();
            dtRecords3.Rows.Clear();
            DGVEvent.Refresh();
        }
        private void ClearStudentTable()
        {
            dtRecords2.Rows.Clear();
            DGVStudent.Refresh();
        }
        private void StudentMySQL()
        {
            connection2.Open();
            command2 = connection2.CreateCommand();
            command2.CommandText =
                "SELECT ID, Forename, Surname, Course, YearLevel " +
                "FROM student_activity_tracker.student_info " +
                "JOIN student_activity_tracker.attendance " +
                "ON attendance.studentID = student_info.ID " +
                "WHERE eventID = " + eventID + " " +
                "AND Course = \"" + course + "\"";

            mdr2 = command2.ExecuteReader();
            dtRecords2.Load(mdr2);
            DGVStudent.DataSource = dtRecords2;

            connection2.Close();
        }

        private void DropdownMonthly_onItemSelected(object sender, EventArgs e)
        {
            choice = "monthly";

            switch (DropdownMonthly.selectedValue)
            {
                case "January":
                    date = "01";
                    ClearEventTable();
                    break;

                case "February":
                    date = "02";
                    ClearEventTable();
                    break;

                case "March":
                    date = "03";
                    ClearEventTable();
                    break;

                case "April":
                    date = "04";
                    ClearEventTable();
                    break;

                case "May":
                    date = "05";
                    ClearEventTable();
                    break;
                case "June":
                    date = "06";
                    ClearEventTable();
                    break;

                case "July":
                    date = "07";
                    ClearEventTable();
                    break;

                case "August":
                    date = "08";
                    ClearEventTable();
                    break;

                case "September":
                    date = "09";
                    ClearEventTable();
                    break;

                case "October":
                    date = "10";
                    ClearEventTable();
                    break;

                case "November":
                    date = "11";
                    ClearEventTable();
                    break;

                case "December":
                    date = "12";
                    ClearEventTable();
                    break;
            }

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT EventID, EventName, Date " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` LIKE \"" + yeardate + "-" + date + "%\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DGVEvent.DataSource = dtRecords;

            connection.Close();
        }

        /*
        private void DropdownQuarterly_onItemSelected(object sender, EventArgs e)
        {
            int increment;
            choice = "quarterly";

            switch (DropdownQuarterly.selectedValue)
            {
                case "1st Quarter":
                    date = "01";
                    ClearEventTable();
                    break;

                case "2nd Quarter":
                    date = "04";
                    ClearEventTable();
                    break;

                case "3rd Quarter":
                    date = "07";
                    ClearEventTable();
                    break;

                case "4th Quarter":
                    date = "10";
                    ClearEventTable();
                    break;
            }

            for (int i = 0; i < 3; i++)
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT EventID, EventName, Date " +
                    "FROM student_activity_tracker.event_info " +
                    "WHERE `Date` LIKE \"" + yeardate + "-" + date + "%\"";

                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DGVEvent.DataSource = dtRecords;
                increment = Convert.ToInt32(date);
                increment++;

                if (increment < 10)
                {
                    date = "0" + increment.ToString();
                }
                else
                {
                    date = increment.ToString();
                }

                connection.Close();
            }
        }
        private void DropdownQuarterly_Enter(object sender, EventArgs e)
        {
            try
            {
                if (DropdownQuarterly.selectedIndex == 4)
                {
                    DropdownQuarterly.RemoveAt(4);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorting out request...");
            }
        }
        */

        private void DGVEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TLPStudentDetails.Visible = false;
                studentRecords.Rows.Clear();

                // Get EventID
                indexRow = e.RowIndex;
                DataGridViewRow row = DGVEvent.Rows[indexRow];
                eventID = row.Cells[0].Value.ToString();

                // Load Present Students
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT ID, Forename, Surname, Course, YearLevel " +
                    "FROM student_activity_tracker.student_info " +
                    "JOIN student_activity_tracker.attendance " +
                    "ON attendance.studentID = student_info.ID " +
                    "WHERE eventID = " + eventID;

                mdr = command.ExecuteReader();
                studentRecords.Load(mdr);
                connection.Close();

                if (studentRecords != null)
                {
                    if (studentRecords.Rows.Count > 0)
                    {
                        TLPStudentDetails.Visible = true;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sorting out request...");
            }
        }

        private void BtnBSCS_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSCS";
            StudentMySQL();
        }
        private void BtnBSCE_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSCE";
            StudentMySQL();
        }
        private void BtnBSHM_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSHM";
            StudentMySQL();
        }
        private void BtnBSTM_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSTM";
            StudentMySQL();
        }
        private void BtnBEED_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BEED";
            StudentMySQL();
        }
        private void BtnBSED_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSED";
            StudentMySQL();
        }
        private void BtnBSBA_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSBA";
            StudentMySQL();
        }
        private void BtnBSN_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSN";
            StudentMySQL();
        }
        private void BtnAB_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "AB";
            StudentMySQL();
        }
        private void BtnBSCrim_Click(object sender, EventArgs e)
        {
            ClearStudentTable();
            course = "BSCrim";
            StudentMySQL();
        }

        private void DTPYearly_ValueChanged(object sender, EventArgs e)
        {
            choice = "yearly";
            yeardate = DTPYearly.Text;
            ClearEventTable();

            DropdownMonthly.selectedIndex = 0;

            connection3.Open();
            command3 = connection3.CreateCommand();
            command3.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.event_info " +
                "WHERE Date LIKE '" + yeardate + "%'";

            mdr3 = command3.ExecuteReader();
            dtRecords3.Load(mdr3);
            DGVEvent.DataSource = dtRecords3;

            connection3.Close();
        }
    }
}
