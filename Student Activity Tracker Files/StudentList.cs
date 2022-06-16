using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Activity_Tracker
{
    public partial class StudentList : Form
    {
        bool checker = false; // checks if add student or edit student
        int indexRow;
        string gender;
        string course;

        // MySQL Fields
        static string DBconnection = "datasource = localhost; username = root; password = ";
        
        MySqlConnection connection = new MySqlConnection(DBconnection);
        DataTable dtRecords = new DataTable();
        MySqlCommand command;
        MySqlDataReader mdr;

        public StudentList()
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
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtEmail.Text = "";
            ComboBoxCourse.SelectedIndex = -1;
            ComboBoxYearLevel.SelectedIndex = -1;
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
        }
        private void ClearTable()
        {
            DVGUser.Visible = true;
            dtRecords.Rows.Clear();
            DVGUser.Refresh();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            checker = true;
            LblAddEvent.Text = "Add Student";
            Timer.Start();
            TLPnlTop.Enabled = false;

            // CATCHING THE NEW STUDENT ID
            connection.Open();
            command = connection.CreateCommand();

            command.CommandText =
                "SELECT ID AS SchoolID " +
                "FROM student_activity_tracker.student_info " +
                "ORDER BY ID DESC LIMIT 1";

            mdr = command.ExecuteReader();
            mdr.Read();
            int temp = Convert.ToInt32(mdr["SchoolID"]);
            temp += 1;
            TextId.Text = temp.ToString();
            connection.Close();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            checker = false;
            LblAddEvent.Text = "Edit Student";
            Timer.Start();
            TLPnlTop.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if(course != null)
            {
                connection.Open();
                command = connection.CreateCommand();

                command.CommandText =
                    "SELECT * " +
                    "FROM student_activity_tracker.student_info " +
                    "WHERE Course = \"" + course + "\"";

                mdr = command.ExecuteReader();
                dtRecords.Load(mdr);
                DVGUser.DataSource = dtRecords;
                connection.Close();
            }
            else
            {
                MessageBox.Show("You have not selected a course.");
            }          
        }


        private void BtnPicDelete_Click(object sender, EventArgs e)
        {
            PicUser.Image = PicUser.ErrorImage;
        }
        private void BtnPicOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                PicUser.ImageLocation = openFileDialog.FileName;
        }


        private void TextId_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TextId);
        }
        private void TxtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtFirstName);
        }
        private void TxtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtLastName);
        }
        private void TxtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(TxtEmail);
        }


        private void TextId_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TextId);
        }
        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtFirstName);
        }
        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtLastName);
        }
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtEmail);
        }
 

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string ID = TextId.Text;
            string FirstName = TxtFirstName.Text;
            string LastName = TxtLastName.Text;
            string Email = TxtEmail.Text;
            string Course = ComboBoxCourse.Text;
            string YearLevel = ComboBoxYearLevel.Text;

            if (MaleRadioButton.Checked)
            {
                gender = "M";
            }
            if (FemaleRadioButton.Checked)
            {
                gender = "F";
            }

            if (checker == true)
            {
                if (ID == "" || FirstName == "" || LastName == "" || Email == "" || Course == " "
                    || (!MaleRadioButton.Checked && !FemaleRadioButton.Checked))
                {
                    MessageBox.Show("ERROR! Please input all required information.");
                }
                else
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText =
                        "INSERT INTO student_activity_tracker.student_info " +
                        "(ID, Forename, Surname, Email, Sex, Course, YearLevel) " +
                        "VALUES ( \"" + ID + "\",\"" + FirstName + "\",\"" + LastName + "\",\"" +
                                Email + "\",\"" + gender + "\",\"" + Course + "\",\"" + YearLevel + "\")";

                    mdr = command.ExecuteReader();
                    dtRecords.Load(mdr);
                    DVGUser.DataSource = dtRecords;
                    connection.Close();

                    MessageBox.Show("You have successfully added a student into the system.");
                    ClearInfo();
                    Timer.Start();
                    TLPnlTop.Enabled = true;
                }
            }
            else
            {
                if (ID == "" || FirstName == "" || LastName == "" || Email == "" || Course == " "
                    || (!MaleRadioButton.Checked && !FemaleRadioButton.Checked))
                {
                    MessageBox.Show("ERROR! Please input all required information.");
                }
                else
                {
                    try
                    {
                        connection.Open();

                        command = connection.CreateCommand();
                        command.CommandText =
                            "UPDATE student_activity_tracker.student_info " +
                            "SET Forename = '" + FirstName + "', Surname = '" + LastName + "', Email = '" + Email + "', Sex = '" + gender + "', Course = '" + Course + "', YearLevel = '" + YearLevel + "' " +
                            "WHERE ID = " + ID;

                        mdr = command.ExecuteReader();
                        dtRecords.Load(mdr);
                        DVGUser.DataSource = dtRecords;
                        connection.Close();

                        MessageBox.Show("You have successfully edited a student's data.");
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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearInfo();
            Timer.Start();
            TLPnlTop.Enabled = true;
        }
        
        
        private void StudentList_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
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


        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = MaleRadioButton.Text;
        }
        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = FemaleRadioButton.Text;
        }

        private void ComboBoxCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }
        private void ComboBoxYearLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }

        private void DVGUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checker == false)
            {
                try
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = DVGUser.Rows[indexRow];

                    TextId.Text = row.Cells[0].Value.ToString();
                    TxtFirstName.Text = row.Cells[1].Value.ToString();
                    TxtLastName.Text = row.Cells[2].Value.ToString();
                    TxtEmail.Text = row.Cells[3].Value.ToString();
                    ComboBoxCourse.Text = row.Cells[5].Value.ToString();
                    ComboBoxYearLevel.Text = row.Cells[6].Value.ToString();

                    if (row.Cells[4].Value.ToString() == "M")
                    {
                        MaleRadioButton.Checked = true;
                    }
                    if (row.Cells[4].Value.ToString() == "F")
                    {
                        FemaleRadioButton.Checked = true;
                    }
                }
                catch (Exception) 
                {
                    MessageBox.Show("Sorting out request...");
                }
            }
            
        }
        private void PicSearch_Click(object sender, EventArgs e)
        {
            course = "search";
            ClearTable();
            connection.Open();

            string selectQuery = "SELECT * " +
                                 "FROM student_activity_tracker.student_info " +
                                 "WHERE ID LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Forename LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Surname LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Email LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Sex LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR Course LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR YearLevel LIKE \"%" + TxtSearch.Text + "%\" " +
                                 "OR TotalPoints LIKE \"%" + TxtSearch.Text + "%\" ";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }

        private void BtnBSCS_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSCS";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
 
            connection.Close();
        }
        private void BtnBSCE_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSCE";
            
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSHM_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSHM";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSTM_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSTM";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBEED_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BEED";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSED_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSED";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSBA_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSBA";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSN_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSN";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnAB_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "AB";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }
        private void BtnBSCrim_Click(object sender, EventArgs e)
        {
            ClearTable();
            TxtSearch.Text = "";
            course = "BSCrim";

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM student_activity_tracker.student_info " +
                "WHERE Course = \"" + course + "\"";

            mdr = command.ExecuteReader();
            dtRecords.Load(mdr);
            DVGUser.DataSource = dtRecords;
            connection.Close();
        }

    }
}
