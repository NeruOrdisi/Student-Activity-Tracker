
namespace Student_Activity_Tracker
{
    partial class InputAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipsePnlSearch = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.LineSearch = new System.Windows.Forms.Label();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.Background = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblAccess = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEventDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlAttendanceFiller = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.LineSearch2 = new System.Windows.Forms.Label();
            this.TxtAttendance = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.Elipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipsePnlForAttendance = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipsesSubmit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuAttendance = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            this.Background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.DGVPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.PnlAttendanceFiller.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panelAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipsePnlSearch
            // 
            this.ElipsePnlSearch.ElipseRadius = 5;
            this.ElipsePnlSearch.TargetControl = this.PnlSearch;
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.PnlSearch.Controls.Add(this.LineSearch);
            this.PnlSearch.Controls.Add(this.PicSearch);
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Location = new System.Drawing.Point(10, 52);
            this.PnlSearch.Margin = new System.Windows.Forms.Padding(10, 4, 10, 6);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(392, 33);
            this.PnlSearch.TabIndex = 6;
            // 
            // LineSearch
            // 
            this.LineSearch.BackColor = System.Drawing.Color.White;
            this.LineSearch.Location = new System.Drawing.Point(-1, 27);
            this.LineSearch.Name = "LineSearch";
            this.LineSearch.Size = new System.Drawing.Size(392, 2);
            this.LineSearch.TabIndex = 7;
            this.LineSearch.Visible = false;
            // 
            // PicSearch
            // 
            this.PicSearch.Image = global::Student_Activity_Tracker.Properties.Resources.search;
            this.PicSearch.Location = new System.Drawing.Point(358, 1);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(31, 25);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSearch.TabIndex = 6;
            this.PicSearch.TabStop = false;
            this.PicSearch.Click += new System.EventHandler(this.PicSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.TxtSearch.Location = new System.Drawing.Point(12, 3);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(12, 12, 12, 8);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(331, 28);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.Background.Controls.Add(this.tableLayoutPanel1);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 640);
            this.Background.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGVPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlAttendanceFiller, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 640);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // DGVPanel
            // 
            this.DGVPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.DGVPanel, 3);
            this.DGVPanel.Controls.Add(this.tableLayoutPanel7);
            this.DGVPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPanel.Location = new System.Drawing.Point(10, 237);
            this.DGVPanel.Margin = new System.Windows.Forms.Padding(10);
            this.DGVPanel.Name = "DGVPanel";
            this.DGVPanel.Size = new System.Drawing.Size(980, 393);
            this.DGVPanel.TabIndex = 14;
            this.DGVPanel.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.DGVUser, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.79592F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(980, 393);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(970, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "STUDENTS PRESENT AT THE EVENT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVUser
            // 
            this.DGVUser.AllowUserToAddRows = false;
            this.DGVUser.AllowUserToDeleteRows = false;
            this.DGVUser.AllowUserToResizeColumns = false;
            this.DGVUser.AllowUserToResizeRows = false;
            this.DGVUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUser.BackgroundColor = System.Drawing.Color.White;
            this.DGVUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUser.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUser.EnableHeadersVisualStyles = false;
            this.DGVUser.GridColor = System.Drawing.Color.White;
            this.DGVUser.Location = new System.Drawing.Point(30, 70);
            this.DGVUser.Margin = new System.Windows.Forms.Padding(30);
            this.DGVUser.MultiSelect = false;
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.ReadOnly = true;
            this.DGVUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUser.RowHeadersVisible = false;
            this.DGVUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVUser.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DGVUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DGVUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVUser.RowTemplate.DividerHeight = 3;
            this.DGVUser.RowTemplate.Height = 40;
            this.DGVUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUser.Size = new System.Drawing.Size(920, 293);
            this.DGVUser.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(726, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 97);
            this.panel4.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.LblAccess, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LblDate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(264, 97);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LblAccess
            // 
            this.LblAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.LblAccess.Location = new System.Drawing.Point(5, 53);
            this.LblAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.LblAccess.Name = "LblAccess";
            this.LblAccess.Size = new System.Drawing.Size(254, 29);
            this.LblAccess.TabIndex = 6;
            this.LblAccess.Text = "NO";
            this.LblAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDate
            // 
            this.LblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblDate.Location = new System.Drawing.Point(5, 15);
            this.LblDate.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(254, 28);
            this.LblDate.TabIndex = 5;
            this.LblDate.Text = "Allow Access?";
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(442, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 97);
            this.panel3.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblEventDate, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 97);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of the Event";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEventDate
            // 
            this.LblEventDate.AutoSize = true;
            this.LblEventDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.LblEventDate.Location = new System.Drawing.Point(5, 53);
            this.LblEventDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.LblEventDate.Name = "LblEventDate";
            this.LblEventDate.Size = new System.Drawing.Size(254, 29);
            this.LblEventDate.TabIndex = 6;
            this.LblEventDate.Text = "DATE OF EVENT";
            this.LblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblEventDate.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 97);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.PnlSearch, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(412, 97);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type The Event ID Below";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlAttendanceFiller
            // 
            this.PnlAttendanceFiller.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.PnlAttendanceFiller, 3);
            this.PnlAttendanceFiller.Controls.Add(this.tableLayoutPanel2);
            this.PnlAttendanceFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAttendanceFiller.Location = new System.Drawing.Point(70, 127);
            this.PnlAttendanceFiller.Margin = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.PnlAttendanceFiller.Name = "PnlAttendanceFiller";
            this.PnlAttendanceFiller.Size = new System.Drawing.Size(860, 90);
            this.PnlAttendanceFiller.TabIndex = 12;
            this.PnlAttendanceFiller.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.97674F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.02325F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Student ID >> ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.60976F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel6.Controls.Add(this.panelAttendance, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.BtnSubmit, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(278, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.76471F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.82353F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.23529F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(579, 84);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panelAttendance.Controls.Add(this.LineSearch2);
            this.panelAttendance.Controls.Add(this.TxtAttendance);
            this.panelAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttendance.Location = new System.Drawing.Point(0, 27);
            this.panelAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(403, 32);
            this.panelAttendance.TabIndex = 7;
            // 
            // LineSearch2
            // 
            this.LineSearch2.BackColor = System.Drawing.Color.White;
            this.LineSearch2.Location = new System.Drawing.Point(-1, 27);
            this.LineSearch2.Name = "LineSearch2";
            this.LineSearch2.Size = new System.Drawing.Size(412, 2);
            this.LineSearch2.TabIndex = 7;
            this.LineSearch2.Visible = false;
            // 
            // TxtAttendance
            // 
            this.TxtAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.TxtAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.TxtAttendance.Location = new System.Drawing.Point(12, 3);
            this.TxtAttendance.Margin = new System.Windows.Forms.Padding(12);
            this.TxtAttendance.Name = "TxtAttendance";
            this.TxtAttendance.Size = new System.Drawing.Size(388, 28);
            this.TxtAttendance.TabIndex = 0;
            this.TxtAttendance.Click += new System.EventHandler(this.TxtAttendance_Click);
            this.TxtAttendance.Leave += new System.EventHandler(this.PanelAttendance_Leave);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubmit.FlatAppearance.BorderSize = 0;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(405, 27);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(125, 32);
            this.BtnSubmit.TabIndex = 8;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Elipse1
            // 
            this.Elipse1.ElipseRadius = 15;
            this.Elipse1.TargetControl = this.panel1;
            // 
            // Elipse2
            // 
            this.Elipse2.ElipseRadius = 15;
            this.Elipse2.TargetControl = this.PnlAttendanceFiller;
            // 
            // Elipse3
            // 
            this.Elipse3.ElipseRadius = 15;
            this.Elipse3.TargetControl = this.panel3;
            // 
            // Elipse4
            // 
            this.Elipse4.ElipseRadius = 15;
            this.Elipse4.TargetControl = this.panel4;
            // 
            // Elipse5
            // 
            this.Elipse5.ElipseRadius = 15;
            this.Elipse5.TargetControl = this.DGVPanel;
            // 
            // ElipsePnlForAttendance
            // 
            this.ElipsePnlForAttendance.ElipseRadius = 15;
            this.ElipsePnlForAttendance.TargetControl = this;
            // 
            // ElipsesSubmit
            // 
            this.ElipsesSubmit.ElipseRadius = 5;
            this.ElipsesSubmit.TargetControl = this.BtnSubmit;
            // 
            // bunifuAttendance
            // 
            this.bunifuAttendance.ElipseRadius = 5;
            this.bunifuAttendance.TargetControl = this.panelAttendance;
            // 
            // InputAttendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.Background);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InputAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            this.Background.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DGVPanel.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.PnlAttendanceFiller.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipsePnlSearch;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEventDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Label LineSearch;
        private System.Windows.Forms.PictureBox PicSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel DGVPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblAccess;
        private System.Windows.Forms.Label LblDate;
        private Bunifu.Framework.UI.BunifuElipse Elipse1;
        private Bunifu.Framework.UI.BunifuElipse Elipse2;
        private Bunifu.Framework.UI.BunifuElipse Elipse3;
        private Bunifu.Framework.UI.BunifuElipse Elipse4;
        private Bunifu.Framework.UI.BunifuElipse Elipse5;
        private Bunifu.Framework.UI.BunifuElipse ElipsePnlForAttendance;
        private System.Windows.Forms.Panel PnlAttendanceFiller;
        private System.Windows.Forms.DataGridView DGVUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Label LineSearch2;
        private System.Windows.Forms.TextBox TxtAttendance;
        private System.Windows.Forms.Button BtnSubmit;
        private Bunifu.Framework.UI.BunifuElipse ElipsesSubmit;
        private Bunifu.Framework.UI.BunifuElipse bunifuAttendance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label5;
    }
}