using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Activity_Tracker
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            AddForm(new Dashboard(), BtnDashboard);
        }

        void AddForm(Form frm, Button btn)
        {
            btn.BackColor = Color.FromArgb(17, 147, 255);
            switch (btn.Name)
            {
                case "BtnDashboard": btn.ImageIndex = 1; break;
                case "BtnEvents": btn.ImageIndex = 3; break;
                case "BtnStudents": btn.ImageIndex = 5; break;
                case "BtnSanction": btn.ImageIndex = 7; break;
                case "BtnSettings": btn.ImageIndex = 9; break;
                default: break;
            }
            PnlNav.Top = btn.Top;
            PnlNav.Height = btn.Height - 30;
            PnlNav.Location = new Point(btn.Location.X, btn.Location.Y + 65);
            PnlPage.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            PnlPage.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        void SelectBtn(Button btn)
        {
            switch (btn.Name)
            {
                case "BtnDashboard": btn.ImageIndex = 1; break;
                case "BtnEvents": btn.ImageIndex = 3; break;
                case "BtnStudents": btn.ImageIndex = 5; break;
                case "BtnSanction": btn.ImageIndex = 7; break;
                case "BtnInputAttendance": btn.ImageIndex = 10; break;
                default: break;
            }
            btn.BackColor = Color.FromArgb(17, 147, 255);

            PnlNav.Top = btn.Top;
            PnlNav.Height = btn.Height - 30;
            PnlNav.Location = new Point(btn.Location.X, btn.Location.Y + 65);
        }
        void ResetBtn()
        {
            foreach (var btn in TLPnlMenu.Controls.OfType<Button>())
                btn.BackColor = Color.FromArgb(17, 153, 248);

            BtnDashboard.ImageIndex = 0;
            BtnEvents.ImageIndex = 2;
            BtnStudents.ImageIndex = 4;
            BtnSanction.ImageIndex = 6;
            BtnInputAttendance.ImageIndex = 11;
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(BtnDashboard);
            AddForm(new Dashboard(), BtnDashboard);
        }
        private void BtnEvents_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(BtnEvents);
            AddForm(new EventList(), BtnEvents);
        }
        private void BtnStudents_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(BtnStudents);
            AddForm(new StudentList(), BtnStudents);
        }
        private void BtnSanction_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(BtnSanction);
            AddForm(new Sanction(), BtnSanction);
        }

        private void BtnInputAttendance_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(BtnInputAttendance);
            AddForm(new InputAttendance(), BtnInputAttendance);
        }

        private void BtnQuick_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/For Programming/VisualStudio C#/Student Activity Tracker/Quick Reference Guide.pdf");
        }
    }
}
