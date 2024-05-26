namespace SchoolSync
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuButton = new PictureBox();
            sidebarMenu = new FlowLayoutPanel();
            panel2 = new Panel();
            NoAllowedAppsControl = new Button();
            panel4 = new Panel();
            SettingsControl = new Button();
            GoogleAccountControl = new Button();
            ReturnControl = new Button();
            sidebarMenuTimer = new System.Windows.Forms.Timer(components);
            homePanel = new Panel();
            calendarWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tableLayoutPanel1 = new TableLayoutPanel();
            LabelFromDateDescription = new Label();
            LabelFromDate = new Label();
            LabelUntilDateDescription = new Label();
            LabelUntilDate = new Label();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebarMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarWebView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(5, 3);
            menuButton.Margin = new Padding(5, 3, 3, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(40, 40);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 2;
            menuButton.TabStop = false;
            menuButton.Click += MenuControl_Clicked;
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = Color.Transparent;
            sidebarMenu.Controls.Add(menuButton);
            sidebarMenu.Controls.Add(panel2);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(GoogleAccountControl);
            sidebarMenu.Controls.Add(ReturnControl);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.MaximumSize = new Size(250, 0);
            sidebarMenu.MinimumSize = new Size(50, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(50, 820);
            sidebarMenu.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(NoAllowedAppsControl);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 60);
            panel2.TabIndex = 3;
            // 
            // NoAllowedAppsControl
            // 
            NoAllowedAppsControl.Location = new Point(-5, -5);
            NoAllowedAppsControl.Name = "NoAllowedAppsControl";
            NoAllowedAppsControl.Size = new Size(260, 70);
            NoAllowedAppsControl.TabIndex = 4;
            NoAllowedAppsControl.Text = "No Allowed Apps";
            NoAllowedAppsControl.UseVisualStyleBackColor = true;
            NoAllowedAppsControl.Click += NoAllowedAppsControl_Clicked;
            // 
            // panel4
            // 
            panel4.Controls.Add(SettingsControl);
            panel4.Location = new Point(3, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 5;
            // 
            // SettingsControl
            // 
            SettingsControl.Location = new Point(-5, -5);
            SettingsControl.Name = "SettingsControl";
            SettingsControl.Size = new Size(260, 70);
            SettingsControl.TabIndex = 4;
            SettingsControl.Text = "Settings";
            SettingsControl.UseVisualStyleBackColor = true;
            SettingsControl.Click += SettingsControl_Clicked;
            // 
            // GoogleAccountControl
            // 
            GoogleAccountControl.Location = new Point(3, 181);
            GoogleAccountControl.Name = "GoogleAccountControl";
            GoogleAccountControl.Size = new Size(260, 70);
            GoogleAccountControl.TabIndex = 5;
            GoogleAccountControl.Text = "Google Account";
            GoogleAccountControl.UseVisualStyleBackColor = true;
            GoogleAccountControl.Click += GoogleAccountControl_Clicked;
            // 
            // ReturnControl
            // 
            ReturnControl.Location = new Point(3, 257);
            ReturnControl.Name = "ReturnControl";
            ReturnControl.Size = new Size(260, 70);
            ReturnControl.TabIndex = 6;
            ReturnControl.Text = "Return";
            ReturnControl.UseVisualStyleBackColor = true;
            ReturnControl.Visible = false;
            ReturnControl.Click += ReturnControl_Clicked;
            // 
            // sidebarMenuTimer
            // 
            sidebarMenuTimer.Interval = 5;
            sidebarMenuTimer.Tick += SidebarMenuTimer_Tick;
            // 
            // homePanel
            // 
            homePanel.BackColor = SystemColors.ActiveCaption;
            homePanel.Controls.Add(calendarWebView);
            homePanel.Location = new Point(50, 50);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1092, 770);
            homePanel.TabIndex = 0;
            // 
            // calendarWebView
            // 
            calendarWebView.AllowExternalDrop = true;
            calendarWebView.BackColor = Color.Gainsboro;
            calendarWebView.CreationProperties = null;
            calendarWebView.DefaultBackgroundColor = Color.Transparent;
            calendarWebView.Dock = DockStyle.Fill;
            calendarWebView.Location = new Point(0, 0);
            calendarWebView.Margin = new Padding(10);
            calendarWebView.MinimumSize = new Size(800, 600);
            calendarWebView.Name = "calendarWebView";
            calendarWebView.Padding = new Padding(10);
            calendarWebView.Size = new Size(1092, 770);
            calendarWebView.Source = new Uri("https://calendar.google.com/calendar/u/0/r", UriKind.Absolute);
            calendarWebView.TabIndex = 0;
            calendarWebView.ZoomFactor = 1D;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(LabelFromDateDescription, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelFromDate, 1, 0);
            tableLayoutPanel1.Controls.Add(LabelUntilDateDescription, 2, 0);
            tableLayoutPanel1.Controls.Add(LabelUntilDate, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(50, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1090, 50);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // LabelFromDateDescription
            // 
            LabelFromDateDescription.AutoSize = true;
            LabelFromDateDescription.Dock = DockStyle.Fill;
            LabelFromDateDescription.Location = new Point(3, 0);
            LabelFromDateDescription.Name = "LabelFromDateDescription";
            LabelFromDateDescription.Size = new Size(266, 50);
            LabelFromDateDescription.TabIndex = 0;
            LabelFromDateDescription.Text = "Days to Count Backwards";
            LabelFromDateDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelFromDate
            // 
            LabelFromDate.AutoSize = true;
            LabelFromDate.Dock = DockStyle.Fill;
            LabelFromDate.Location = new Point(275, 0);
            LabelFromDate.Name = "LabelFromDate";
            LabelFromDate.Size = new Size(266, 50);
            LabelFromDate.TabIndex = 1;
            LabelFromDate.Text = "0";
            LabelFromDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelUntilDateDescription
            // 
            LabelUntilDateDescription.AutoSize = true;
            LabelUntilDateDescription.Dock = DockStyle.Fill;
            LabelUntilDateDescription.Location = new Point(547, 0);
            LabelUntilDateDescription.Name = "LabelUntilDateDescription";
            LabelUntilDateDescription.Size = new Size(266, 50);
            LabelUntilDateDescription.TabIndex = 2;
            LabelUntilDateDescription.Text = "Days to Count Forward";
            LabelUntilDateDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelUntilDate
            // 
            LabelUntilDate.AutoSize = true;
            LabelUntilDate.Dock = DockStyle.Fill;
            LabelUntilDate.Location = new Point(819, 0);
            LabelUntilDate.Name = "LabelUntilDate";
            LabelUntilDate.Size = new Size(268, 50);
            LabelUntilDate.TabIndex = 3;
            LabelUntilDate.Text = "0";
            LabelUntilDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 820);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sidebarMenu);
            Controls.Add(homePanel);
            IsMdiContainer = true;
            MinimumSize = new Size(800, 600);
            Name = "HomeForm";
            SizeGripStyle = SizeGripStyle.Show;
            FormClosing += HomeForm_FormClosing;
            SizeChanged += HomeForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebarMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calendarWebView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox menuButton;
        private FlowLayoutPanel sidebarMenu;
        private Panel panel2;
        private Button btnNoAllowedApps;
        private Panel panel3;
        private Button btnGoogleAccount;
        private Panel panel4;
        private Button btnSettings;
        private System.Windows.Forms.Timer sidebarMenuTimer;
        private Panel homePanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 calendarWebView;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LabelFromDateDescription;
        private Label LabelFromDate;
        private Label LabelUntilDateDescription;
        private Label LabelUntilDate;
        private Button NoAllowedAppsControl;
        private Button SettingsControl;
        private Button GoogleAccountControl;
        private Button ReturnControl;
    }
}
