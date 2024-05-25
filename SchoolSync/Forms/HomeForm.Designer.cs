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
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuButton = new PictureBox();
            sidebarMenu = new FlowLayoutPanel();
            panel2 = new Panel();
            btnNoAllowedApps = new Button();
            panel4 = new Panel();
            btnSettings = new Button();
            panel3 = new Panel();
            btnGoogleAccount = new Button();
            sidebarMenuTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebarMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(56, 12);
            webView2.Name = "webView2";
            webView2.Size = new Size(242, 158);
            webView2.TabIndex = 0;
            webView2.ZoomFactor = 1D;
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
            menuButton.Click += menuButton_Click;
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = Color.DimGray;
            sidebarMenu.Controls.Add(menuButton);
            sidebarMenu.Controls.Add(panel2);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.MaximumSize = new Size(250, 0);
            sidebarMenu.MinimumSize = new Size(50, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(50, 761);
            sidebarMenu.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNoAllowedApps);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 60);
            panel2.TabIndex = 3;
            // 
            // btnNoAllowedApps
            // 
            btnNoAllowedApps.Location = new Point(-5, -5);
            btnNoAllowedApps.Name = "btnNoAllowedApps";
            btnNoAllowedApps.Size = new Size(260, 70);
            btnNoAllowedApps.TabIndex = 4;
            btnNoAllowedApps.Text = "No Allowed Apps";
            btnNoAllowedApps.UseVisualStyleBackColor = true;
            btnNoAllowedApps.Click += btnNoAllowedApps_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSettings);
            panel4.Location = new Point(3, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 5;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(-5, -5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(260, 70);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Google Account";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGoogleAccount);
            panel3.Location = new Point(3, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 60);
            panel3.TabIndex = 4;
            // 
            // btnGoogleAccount
            // 
            btnGoogleAccount.Location = new Point(-5, -5);
            btnGoogleAccount.Name = "btnGoogleAccount";
            btnGoogleAccount.Size = new Size(260, 70);
            btnGoogleAccount.TabIndex = 4;
            btnGoogleAccount.Text = "Settings";
            btnGoogleAccount.UseVisualStyleBackColor = true;
            btnGoogleAccount.Click += btnGoogleAccount_Click;
            // 
            // sidebarMenuTimer
            // 
            sidebarMenuTimer.Interval = 5;
            sidebarMenuTimer.Tick += sidebarMenuTimer_Tick;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 761);
            Controls.Add(sidebarMenu);
            Controls.Add(webView2);
            IsMdiContainer = true;
            MinimumSize = new Size(1280, 800);
            Name = "HomeForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebarMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private PictureBox menuButton;
        private FlowLayoutPanel sidebarMenu;
        private Panel panel2;
        private Button btnNoAllowedApps;
        private Panel panel3;
        private Button btnGoogleAccount;
        private Panel panel4;
        private Button btnSettings;
        private System.Windows.Forms.Timer sidebarMenuTimer;
    }
}
