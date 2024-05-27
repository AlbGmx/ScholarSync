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
            panel3 = new Panel();
            GoogleAccountControl = new Button();
            returnControl = new Button();
            sidebarMenuTimer = new System.Windows.Forms.Timer(components);
            homePanel = new Panel();
            calendarWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebarMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarWebView).BeginInit();
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
            sidebarMenu.BackColor = Color.DarkGray;
            sidebarMenu.Controls.Add(menuButton);
            sidebarMenu.Controls.Add(panel2);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Controls.Add(returnControl);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.MaximumSize = new Size(250, 0);
            sidebarMenu.MinimumSize = new Size(50, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(50, 820);
            sidebarMenu.TabIndex = 0;
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
            // panel3
            // 
            panel3.Controls.Add(GoogleAccountControl);
            panel3.Location = new Point(3, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 60);
            panel3.TabIndex = 4;
            // 
            // GoogleAccountControl
            // 
            GoogleAccountControl.Location = new Point(-5, -5);
            GoogleAccountControl.Name = "GoogleAccountControl";
            GoogleAccountControl.Size = new Size(260, 70);
            GoogleAccountControl.TabIndex = 4;
            GoogleAccountControl.Text = "Google Account";
            GoogleAccountControl.UseVisualStyleBackColor = true;
            GoogleAccountControl.Click += GoogleAccountControl_Clicked;
            // 
            // returnControl
            // 
            returnControl.Location = new Point(3, 247);
            returnControl.Name = "returnControl";
            returnControl.Size = new Size(260, 70);
            returnControl.TabIndex = 4;
            returnControl.Text = "Regresar a Inicio";
            returnControl.UseVisualStyleBackColor = true;
            returnControl.Visible = false;
            returnControl.Click += ReturnContol_Clicked;
            // 
            // sidebarMenuTimer
            // 
            sidebarMenuTimer.Interval = 5;
            sidebarMenuTimer.Tick += SidebarMenuTimer_Tick;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.White;
            homePanel.Controls.Add(calendarWebView);
            homePanel.Location = new Point(50, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1092, 820);
            homePanel.TabIndex = 0;
            // 
            // calendarWebView
            // 
            calendarWebView.AllowExternalDrop = true;
            calendarWebView.BackColor = SystemColors.Menu;
            calendarWebView.CreationProperties = null;
            calendarWebView.DefaultBackgroundColor = Color.IndianRed;
            calendarWebView.Dock = DockStyle.Fill;
            calendarWebView.Location = new Point(0, 0);
            calendarWebView.Margin = new Padding(10);
            calendarWebView.MinimumSize = new Size(800, 600);
            calendarWebView.Name = "calendarWebView";
            calendarWebView.Padding = new Padding(10);
            calendarWebView.Size = new Size(1092, 820);
            calendarWebView.Source = new Uri("https://calendar.google.com/calendar/u/0/r", UriKind.Absolute);
            calendarWebView.TabIndex = 0;
            calendarWebView.ZoomFactor = 1D;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 820);
            Controls.Add(sidebarMenu);
            Controls.Add(homePanel);
            IsMdiContainer = true;
            MinimumSize = new Size(800, 600);
            Name = "HomeForm";
            SizeGripStyle = SizeGripStyle.Show;
            SizeChanged += HomeForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebarMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calendarWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox menuButton;
        private FlowLayoutPanel sidebarMenu;
        private Panel panel2;
        private Button NoAllowedAppsControl;
        private Panel panel3;
        private Button GoogleAccountControl;
        private Panel panel4;
        private Button SettingsControl;
        private System.Windows.Forms.Timer sidebarMenuTimer;
        private Panel homePanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 calendarWebView;
        private Button returnControl;
    }
}
