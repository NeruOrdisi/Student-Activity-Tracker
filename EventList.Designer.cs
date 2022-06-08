
namespace Student_Activity_Tracker
{
    partial class EventList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.TLPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.LineSearch = new System.Windows.Forms.Label();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ElipsePnlSearch = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseAddPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TlPnlAdd = new System.Windows.Forms.TableLayoutPanel();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtPoints = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtEventName = new System.Windows.Forms.TextBox();
            this.NameOfEvent = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.DateOfEvent = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblAddEvent = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DVGUser = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DTPYearly = new System.Windows.Forms.DateTimePicker();
            this.DropdownMonthly = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.TLPnlTop.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            this.PnlAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TlPnlAdd.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGUser)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            // 
            // TLPnlTop
            // 
            this.TLPnlTop.ColumnCount = 5;
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlTop.Controls.Add(this.BtnRefresh, 2, 0);
            this.TLPnlTop.Controls.Add(this.PnlSearch, 4, 0);
            this.TLPnlTop.Controls.Add(this.BtnEdit, 1, 0);
            this.TLPnlTop.Controls.Add(this.BtnAdd, 0, 0);
            this.TLPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnlTop.Location = new System.Drawing.Point(2, 2);
            this.TLPnlTop.Name = "TLPnlTop";
            this.TLPnlTop.RowCount = 1;
            this.TLPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlTop.Size = new System.Drawing.Size(996, 60);
            this.TLPnlTop.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::Student_Activity_Tracker.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(183, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(84, 54);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // PnlSearch
            // 
            this.PnlSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.PnlSearch.Controls.Add(this.LineSearch);
            this.PnlSearch.Controls.Add(this.PicSearch);
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Location = new System.Drawing.Point(370, 12);
            this.PnlSearch.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(304, 35);
            this.PnlSearch.TabIndex = 4;
            // 
            // LineSearch
            // 
            this.LineSearch.BackColor = System.Drawing.Color.White;
            this.LineSearch.Location = new System.Drawing.Point(0, 30);
            this.LineSearch.Name = "LineSearch";
            this.LineSearch.Size = new System.Drawing.Size(300, 2);
            this.LineSearch.TabIndex = 7;
            this.LineSearch.Visible = false;
            // 
            // PicSearch
            // 
            this.PicSearch.Image = global::Student_Activity_Tracker.Properties.Resources.search;
            this.PicSearch.Location = new System.Drawing.Point(266, 3);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(35, 26);
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
            this.TxtSearch.Location = new System.Drawing.Point(4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(256, 28);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = global::Student_Activity_Tracker.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(93, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(84, 54);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = global::Student_Activity_Tracker.Properties.Resources.add;
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(84, 54);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ElipsePnlSearch
            // 
            this.ElipsePnlSearch.ElipseRadius = 20;
            this.ElipsePnlSearch.TargetControl = this.PnlSearch;
            // 
            // ElipseAddPanel
            // 
            this.ElipseAddPanel.ElipseRadius = 15;
            this.ElipseAddPanel.TargetControl = this.PnlAdd;
            // 
            // PnlAdd
            // 
            this.PnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.PnlAdd.Controls.Add(this.panel2);
            this.PnlAdd.Controls.Add(this.panel4);
            this.PnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlAdd.Location = new System.Drawing.Point(698, 62);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Size = new System.Drawing.Size(300, 536);
            this.PnlAdd.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.TlPnlAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 486);
            this.panel2.TabIndex = 1;
            // 
            // TlPnlAdd
            // 
            this.TlPnlAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlPnlAdd.ColumnCount = 3;
            this.TlPnlAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlPnlAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlPnlAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlPnlAdd.Controls.Add(this.TxtAddress, 0, 6);
            this.TlPnlAdd.Controls.Add(this.label11, 0, 5);
            this.TlPnlAdd.Controls.Add(this.label12, 0, 7);
            this.TlPnlAdd.Controls.Add(this.TxtPoints, 0, 4);
            this.TlPnlAdd.Controls.Add(this.label13, 0, 4);
            this.TlPnlAdd.Controls.Add(this.TxtEventName, 0, 3);
            this.TlPnlAdd.Controls.Add(this.NameOfEvent, 0, 2);
            this.TlPnlAdd.Controls.Add(this.label14, 0, 0);
            this.TlPnlAdd.Controls.Add(this.TextId, 0, 1);
            this.TlPnlAdd.Controls.Add(this.DateOfEvent, 0, 8);
            this.TlPnlAdd.Location = new System.Drawing.Point(0, 33);
            this.TlPnlAdd.Margin = new System.Windows.Forms.Padding(0);
            this.TlPnlAdd.Name = "TlPnlAdd";
            this.TlPnlAdd.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.TlPnlAdd.RowCount = 22;
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlPnlAdd.Size = new System.Drawing.Size(283, 401);
            this.TlPnlAdd.TabIndex = 0;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TlPnlAdd.SetColumnSpan(this.TxtAddress, 3);
            this.TxtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAddress.Location = new System.Drawing.Point(15, 215);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(253, 30);
            this.TxtAddress.TabIndex = 24;
            this.TxtAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtAddress_MouseClick);
            this.TxtAddress.Leave += new System.EventHandler(this.TxtAddress_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.TlPnlAdd.SetColumnSpan(this.label11, 2);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 30);
            this.label11.TabIndex = 23;
            this.label11.Text = "Location of Event";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.TlPnlAdd.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "Date of Event";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPoints
            // 
            this.TxtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TlPnlAdd.SetColumnSpan(this.TxtPoints, 3);
            this.TxtPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPoints.Location = new System.Drawing.Point(15, 155);
            this.TxtPoints.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TxtPoints.Multiline = true;
            this.TxtPoints.Name = "TxtPoints";
            this.TxtPoints.Size = new System.Drawing.Size(253, 30);
            this.TxtPoints.TabIndex = 16;
            this.TxtPoints.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPoints_MouseClick);
            this.TxtPoints.Leave += new System.EventHandler(this.TxtPoints_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.TlPnlAdd.SetColumnSpan(this.label13, 3);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 30);
            this.label13.TabIndex = 15;
            this.label13.Text = "Corresponding Points";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtEventName
            // 
            this.TxtEventName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TlPnlAdd.SetColumnSpan(this.TxtEventName, 3);
            this.TxtEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEventName.Location = new System.Drawing.Point(15, 95);
            this.TxtEventName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TxtEventName.Multiline = true;
            this.TxtEventName.Name = "TxtEventName";
            this.TxtEventName.Size = new System.Drawing.Size(253, 30);
            this.TxtEventName.TabIndex = 12;
            this.TxtEventName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtEventName_MouseClick);
            this.TxtEventName.Leave += new System.EventHandler(this.TxtEventName_Leave);
            // 
            // NameOfEvent
            // 
            this.NameOfEvent.AutoSize = true;
            this.TlPnlAdd.SetColumnSpan(this.NameOfEvent, 2);
            this.NameOfEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameOfEvent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfEvent.ForeColor = System.Drawing.Color.White;
            this.NameOfEvent.Location = new System.Drawing.Point(15, 65);
            this.NameOfEvent.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NameOfEvent.Name = "NameOfEvent";
            this.NameOfEvent.Size = new System.Drawing.Size(169, 30);
            this.NameOfEvent.TabIndex = 11;
            this.NameOfEvent.Text = "Name of Event";
            this.NameOfEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.TlPnlAdd.SetColumnSpan(this.label14, 2);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 30);
            this.label14.TabIndex = 8;
            this.label14.Text = "Event ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextId
            // 
            this.TextId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TlPnlAdd.SetColumnSpan(this.TextId, 2);
            this.TextId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextId.Enabled = false;
            this.TextId.Location = new System.Drawing.Point(15, 35);
            this.TextId.Margin = new System.Windows.Forms.Padding(5, 0, 50, 0);
            this.TextId.Multiline = true;
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(119, 30);
            this.TextId.TabIndex = 9;
            this.TextId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextId_MouseClick);
            this.TextId.Leave += new System.EventHandler(this.TextId_Leave);
            // 
            // DateOfEvent
            // 
            this.TlPnlAdd.SetColumnSpan(this.DateOfEvent, 2);
            this.DateOfEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateOfEvent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfEvent.Location = new System.Drawing.Point(15, 275);
            this.DateOfEvent.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DateOfEvent.Name = "DateOfEvent";
            this.DateOfEvent.Size = new System.Drawing.Size(169, 30);
            this.DateOfEvent.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblAddEvent);
            this.panel4.Controls.Add(this.BtnAccept);
            this.panel4.Controls.Add(this.BtnCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 50);
            this.panel4.TabIndex = 0;
            // 
            // LblAddEvent
            // 
            this.LblAddEvent.AutoSize = true;
            this.LblAddEvent.ForeColor = System.Drawing.Color.White;
            this.LblAddEvent.Location = new System.Drawing.Point(185, 14);
            this.LblAddEvent.Name = "LblAddEvent";
            this.LblAddEvent.Size = new System.Drawing.Size(113, 29);
            this.LblAddEvent.TabIndex = 3;
            this.LblAddEvent.Text = "Add Event";
            this.LblAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Image = global::Student_Activity_Tracker.Properties.Resources.accept;
            this.BtnAccept.Location = new System.Drawing.Point(55, 0);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(55, 50);
            this.BtnAccept.TabIndex = 2;
            this.BtnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = global::Student_Activity_Tracker.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(0, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(55, 50);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DVGUser
            // 
            this.DVGUser.AllowUserToAddRows = false;
            this.DVGUser.AllowUserToDeleteRows = false;
            this.DVGUser.AllowUserToResizeColumns = false;
            this.DVGUser.AllowUserToResizeRows = false;
            this.DVGUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVGUser.BackgroundColor = System.Drawing.Color.White;
            this.DVGUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVGUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVGUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DVGUser.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVGUser.DefaultCellStyle = dataGridViewCellStyle6;
            this.DVGUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGUser.EnableHeadersVisualStyles = false;
            this.DVGUser.GridColor = System.Drawing.Color.White;
            this.DVGUser.Location = new System.Drawing.Point(30, 0);
            this.DVGUser.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.DVGUser.MultiSelect = false;
            this.DVGUser.Name = "DVGUser";
            this.DVGUser.ReadOnly = true;
            this.DVGUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DVGUser.RowHeadersVisible = false;
            this.DVGUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DVGUser.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DVGUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVGUser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DVGUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.DVGUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DVGUser.RowTemplate.DividerHeight = 3;
            this.DVGUser.RowTemplate.Height = 40;
            this.DVGUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGUser.Size = new System.Drawing.Size(636, 446);
            this.DVGUser.TabIndex = 7;
            this.DVGUser.Visible = false;
            this.DVGUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGUser_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DVGUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.80597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.19403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 536);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DTPYearly, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DropdownMonthly, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 54);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // DTPYearly
            // 
            this.DTPYearly.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DTPYearly.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DTPYearly.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DTPYearly.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DTPYearly.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DTPYearly.CustomFormat = "yyyy";
            this.DTPYearly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPYearly.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPYearly.Location = new System.Drawing.Point(348, 18);
            this.DTPYearly.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DTPYearly.Name = "DTPYearly";
            this.DTPYearly.ShowUpDown = true;
            this.DTPYearly.Size = new System.Drawing.Size(339, 35);
            this.DTPYearly.TabIndex = 1;
            this.DTPYearly.ValueChanged += new System.EventHandler(this.DTPYearly_ValueChanged);
            // 
            // DropdownMonthly
            // 
            this.DropdownMonthly.BackColor = System.Drawing.Color.Transparent;
            this.DropdownMonthly.BorderRadius = 5;
            this.DropdownMonthly.DisabledColor = System.Drawing.Color.Gray;
            this.DropdownMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropdownMonthly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownMonthly.ForeColor = System.Drawing.Color.White;
            this.DropdownMonthly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DropdownMonthly.Items = new string[] {
        "Monthly",
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"};
            this.DropdownMonthly.Location = new System.Drawing.Point(5, 5);
            this.DropdownMonthly.Margin = new System.Windows.Forms.Padding(5);
            this.DropdownMonthly.Name = "DropdownMonthly";
            this.DropdownMonthly.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.DropdownMonthly.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.tableLayoutPanel2.SetRowSpan(this.DropdownMonthly, 2);
            this.DropdownMonthly.selectedIndex = 0;
            this.DropdownMonthly.Size = new System.Drawing.Size(335, 44);
            this.DropdownMonthly.TabIndex = 0;
            this.DropdownMonthly.onItemSelected += new System.EventHandler(this.DropdownMonthly_onItemSelected_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(348, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yearly";
            // 
            // EventList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PnlAdd);
            this.Controls.Add(this.TLPnlTop);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventList";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EventList_Load);
            this.TLPnlTop.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            this.PnlAdd.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TlPnlAdd.ResumeLayout(false);
            this.TlPnlAdd.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGUser)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel TLPnlTop;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Label LineSearch;
        private System.Windows.Forms.PictureBox PicSearch;
        private Bunifu.Framework.UI.BunifuElipse ElipsePnlSearch;
        private Bunifu.Framework.UI.BunifuElipse ElipseAddPanel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel PnlAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblAddEvent;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridView DVGUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuDropdown DropdownMonthly;
        private System.Windows.Forms.TableLayoutPanel TlPnlAdd;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtPoints;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtEventName;
        private System.Windows.Forms.Label NameOfEvent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.DateTimePicker DateOfEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPYearly;
    }
}