using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Activity_Tracker
{
    public partial class Dashboard : Form
    {

        // MySQL Field
        static string DBconnection = "datasource = localhost; username = root; password = ";

        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        MySqlConnection connection2 = new MySqlConnection(DBconnection);
        DataTable dtRecords2 = new DataTable();
        MySqlCommand command2;
        MySqlDataReader mdr2;

        public Dashboard()
        {
            InitializeComponent();
            LoadDataIntoUpcomingEventsDGV();
            LowestPoints();
            TotalPointsAccumulator();

            DateTime _date = DateTime.Now;
            var _dateString = _date.ToString("MMMM dd, yyyy (ddd)");
            Date.Text = _dateString;
        }

        private void LoadDataIntoUpcomingEventsDGV()
        {
            // Upcoming Events
            string myDate;

            DateTime _date = DateTime.Now;
            var _dateString = _date.ToString("yyyy-MM-dd");
            myDate = _dateString;

            connection.Open();

            command = connection.CreateCommand();
            command.CommandText =
                "SELECT `EventName`, `Date` " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` >  \"" + myDate + "\""; 

            mdr = command.ExecuteReader();            
            dtRecords.Load(mdr);
            UpcomingEvents.DataSource = dtRecords;

            connection.Close();

            // Total Events For The Month
            _dateString = _date.ToString("yyyy-MM");
            myDate = _dateString;

            connection.Open();

            command = connection.CreateCommand();
            command.CommandText =
                "SELECT COUNT(`Date`) AS EventsThisMonth " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` LIKE \"" + myDate + "%\"";

            mdr = command.ExecuteReader();
            mdr.Read();
            LblEventsThisMonth.Text = mdr["EventsThisMonth"].ToString();

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


            for(int i = 0; i < count; i++)
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

            LblTotalPoints.Text = "TOTAL POINTS : " + TotalPoints.ToString();
        }
        private void LowestPoints()
        {
            connection2.Open();

            command2 = connection2.CreateCommand();
            command2.CommandText =
                "SELECT ID, Forename, Surname, Course, TotalPoints " +
                "FROM student_activity_tracker.student_info " +
                "ORDER BY TotalPoints ASC " +
                "LIMIT 10";

            mdr2 = command2.ExecuteReader();
            dtRecords2.Load(mdr2);
            DGVLowestPoints.DataSource = dtRecords2;

            connection2.Close();
        }
    }
}
