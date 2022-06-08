using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Activity_Tracker
{
    public partial class EventList : Form
    {
        int indexRow;
        bool checker = false;
        string date;
        string yeardate = "2022";
        string choice;

        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password =; Convert Zero Datetime=True";
        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        public EventList()
        {
            InitializeComponent();

            // Selection Mode
            DVGUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DVGUser.MultiSelect = false;
        }


        void SelectTxt(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void LeaveTxt(TextBox txt)
        {
            txt.BackColor = Color.White;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PnlAdd.Width == 300)
            {
               TlPnlAdd.Visible = false;
                for (int i = 0; i < 10; i++)
                    PnlAdd.Width = PnlAdd.Width - 30;
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    PnlAdd.Width = PnlAdd.Width + 30;
                TlPnlAdd.Visible = true;
            }

            Timer.Stop();
        }
        private void ClearInfo()
        {
            TextId.Text = "";
            TxtEventName.Text = "";
            TxtPoints.Text = "";
            TxtAddress.Text = "";
            DateOfEvent.Text = "";
        }
        private void ClearTable()
        {
            DVGUser.Visible = true;
            dtRecords.Rows.Clear();
            DVGUser.Refresh();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearInfo();
            checker = true;
            LblAddEvent.Text = "Add Event";
            Timer.Start();
            TLPnlTop.Enabled = false;

            // CATCHING THE NEW EVENT ID
            connection.Open();
            command = connection.CreateCommand();

            command.CommandText =
                "SELECT EventID " +
                "FROM student_activity_tracker.event_info " +
                "ORDER BY EventID DESC LIMIT 1";

            mdr = command.ExecuteReader();
            mdr.Read();
            int temp = Convert.ToInt32(mdr["EventID"]);
            temp += 1;
            TextId.Text = temp.ToString();
            connection.Close();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            checker = false;
            LblAddEvent.Text = "Edit Event";
            Timer.Start();
            TLPnlTop.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (choice == "monthly" || choice == "quarterly")
            {
                connection.Open();
                command = connection.CreateCommand();

                command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` LIKE \"" + yeardate + "-" + date + "%\"";

                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DVGUser.DataSource = dtRecords;
                connection.Close();
            }
            else if (choice == "yearly")
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText =
                    "SELECT * " +
                    "FROM student_activity_tracker.event_info " +
                    "WHERE `Date` LIKE \"" + yeardate + "%\"";

                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DVGUser.DataSource = dtRecords;

                connection.Close();
            }
            else
            {
                MessageBox.Show("You have not selected a date.");
            }
        }


        private void TextId_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TextId);
        }
        private void TxtEventName_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtEventName);
        }
        private void TxtPoints_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtPoints);
        }
        private void TxtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtAddress);
        }


        private void TextId_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TextId);
        }
        private void TxtEventName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtEventName);
        }
        private void TxtPoints_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtPoints);
        }
        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtAddress);
        }


        private void BtnAccept_Click(object sender, EventArgs e)
        {
            DateTime _date = DateTime.Now;
            var _dateString = _date.ToString("yyyy-MM-dd");
            string myDate = _dateString;


            string ID = TextId.Text;
            string EventName = TxtEventName.Text;
            string Points = TxtPoints.Text;
            string Address = TxtAddress.Text;
            DateTime Date = Convert.ToDateTime(DateOfEvent.Text);

            if (checker == true)
            {
                if (ID == "" || EventName == "" || Points == "" || Address == "" || Date.ToString() == "")
                {
                    MessageBox.Show("ERROR! Please input all required information.");
                }
                else
                {

                    if(myDate != Date.ToString("yyyy-MM-dd"))
                    {
                        MessageBox.Show("You cannot add an event with a date that's already happened.");
                    }
                    else
                    {
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText =
                            "INSERT INTO student_activity_tracker.event_info " +
                            "(EventID, EventName, Location, Points, Date) " +
                            "VALUES (\"" + TextId.Text + "\",\"" + EventName + "\",\"" + Address + "\",\"" + Points + "\",\"" + Date.ToString("yyyy-MM-dd") + "\")";

                        mdr = command.ExecuteReader();
                        dtRecords.Load(mdr);
                        DVGUser.DataSource = dtRecords;
                        connection.Close();

                        MessageBox.Show("You have successfully added an event into the system.");
                        ClearInfo();
                        Timer.Start();
                        TLPnlTop.Enabled = true;
                    }
                }
            }
            else
            {
                if (ID == "" || EventName == "" || Points == "" || Address == "" || Date.ToString() == "")
                {
                    MessageBox.Show("ERROR! Please input all required information.");
                }
                else
                {
                    if (myDate != Date.ToString("yyyy-MM-dd"))
                    {
                        MessageBox.Show("Please choose a date that hasn't happened yet.");
                    }
                    else
                    {
                        try
                        {
                            connection.Open();

                            command = connection.CreateCommand();
                            command.CommandText =
                                "UPDATE student_activity_tracker.event_info " +
                                "SET EventName = \"" + EventName + "\", Points = \"" + Points + "\", Location = \"" + Address + "\", Date = \"" + Date.ToString("yyyy-MM-dd") + "\" " +
                                "WHERE EventID = " + ID;

                            mdr = command.ExecuteReader();
                            dtRecords.Load(mdr);
                            DVGUser.DataSource = dtRecords;
                            connection.Close();

                            MessageBox.Show("You have successfully edited an event.");
                            ClearInfo();
                            Timer.Start();
                            TLPnlTop.Enabled = true;

                            connection.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sorting out request...");
                            connection.Close();
                        }
                    }
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearInfo();
            Timer.Start();
            TLPnlTop.Enabled = true;
        }


        private void EventList_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
        }
        private void TxtSearch_Click(object sender, EventArgs e)
        {
            PnlSearch.BackColor = Color.FromArgb(139,199,255);
            TxtSearch.BackColor = Color.FromArgb(139, 199, 255);
            LineSearch.Visible = true;
        }
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            PnlSearch.BackColor = Color.FromArgb(99,180,255);
            TxtSearch.BackColor = Color.FromArgb(99,180,255);
            LineSearch.Visible = false;
        }
        private void PicSearch_Click(object sender, EventArgs e)
        {
            ClearTable();
            connection.Open();

            string selectQuery = "SELECT * FROM student_activity_tracker.event_info " +
                                 "WHERE EventID LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR EventName LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Location LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Points LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR DATE LIKE \"%" + TxtSearch.Text + "%\" ";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void DVGUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(checker == false)
            {
                try
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = DVGUser.Rows[indexRow];

                    TextId.Text = row.Cells[0].Value.ToString();
                    TxtEventName.Text = row.Cells[1].Value.ToString();
                    TxtAddress.Text = row.Cells[2].Value.ToString();
                    TxtPoints.Text = row.Cells[3].Value.ToString();
                    DateOfEvent.Text = row.Cells[4].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sorting out request...");
                }
            }
        }


        private void DropdownMonthly_onItemSelected_1(object sender, EventArgs e)
        {
            choice = "monthly";

            switch (DropdownMonthly.selectedValue)
            {
                case "January":
                    date = "01";
                    ClearTable();
                    break;

                case "February":
                    date = "02";
                    ClearTable();
                    break;

                case "March":
                    date = "03";
                    ClearTable();
                    break;

                case "April":
                    date = "04";
                    ClearTable();
                    break;

                case "May":
                    date = "05";
                    ClearTable();
                    break;
                case "June":
                    date = "06";
                    ClearTable();
                    break;

                case "July":
                    date = "07";
                    ClearTable();
                    break;

                case "August":
                    date = "08";
                    ClearTable();
                    break;

                case "September":
                    date = "09";
                    ClearTable();
                    break;

                case "October":
                    date = "10";
                    ClearTable();
                    break;

                case "November":
                    date = "11";
                    ClearTable();
                    break;

                case "December":
                    date = "12";
                    ClearTable();
                    break;
            }

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.event_info " +
                "WHERE `Date` LIKE \"" + yeardate + "-" + date + "%\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;

            connection.Close();
        }
        
        private void DTPYearly_ValueChanged(object sender, EventArgs e)
        {
            choice = "yearly";
            yeardate = DTPYearly.Text;
            ClearTable();

            DropdownMonthly.selectedIndex = 0;

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.event_info " +
                "WHERE Date LIKE '"+yeardate+"%'";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;

            connection.Close();
        }
    }
}
