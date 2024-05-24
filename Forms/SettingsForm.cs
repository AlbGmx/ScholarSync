namespace ScholarSync.Forms
{
    public partial class SettingsForm : Form
    {
        private int PageWidth { get; set; }
        private int PageHeight { get; set; }
        private BlockedApps? blockedApps;
        private Button? btnBlockedAppList;
        private Button? btnDayRanges;
        private Button? btnGoogleCalendar;
        private Button? btnBack;
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        public SettingsForm()
        {
            PageWidth = (int)(Screen.PrimaryScreen?.Bounds.Width * 0.5 ?? 0);
            PageHeight = (int)(Screen.PrimaryScreen?.Bounds.Height * 0.5 ?? 0);
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(PageWidth, PageHeight);
            Text = "Ajustes";
            Resize += new EventHandler(SettingsForm_Resize);
        }

        private Button CreateButton(string text)
        {
            Button button = new Button
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter
            };

            return button;
        }

        private void InitializeButtons()
        {
            btnBlockedAppList = CreateButton("APLICACIONES NO PERMITIDAS");
            btnBlockedAppList.Name = "btnBlockedAppList";
            btnBlockedAppList.Click += new EventHandler(BlockedAppsButton_Clicked);
            Controls.Add(btnBlockedAppList);

            btnDayRanges = CreateButton("AJUSTES DE RANGO");
            btnDayRanges.Name = "btnDayRanges";
            Controls.Add(btnDayRanges);

            btnGoogleCalendar = CreateButton("GOOGLE CALENDAR");
            btnGoogleCalendar.Name = "btnGoogleCalendar";
            Controls.Add(btnGoogleCalendar);

            btnBack = CreateButton("Atras");
            btnBack.Name = "btnBack";
            btnBack.Click += new EventHandler(BackButton_Clicked);
            Controls.Add(btnBack);
            

            ResizeButtons();
        }

        private void SettingsForm_Resize(object? sender, EventArgs e)
        {
            ResizeButtons();
        }

        private void ResizeButtons()
        {
            int buttonWidth = (int)(ClientSize.Width / 3.0);
            int buttonHeight = (int)(ClientSize.Height / 6.0);
            int spacing = 20;

            // Calculate the total height needed for all buttons and spacing
            int totalHeight = 3 * buttonHeight + 2 * spacing;
            // Calculate the top margin so that the space above the first button and below the last button is equal to the spacing between buttons
            int margin = (ClientSize.Height - totalHeight) / 4;

            if (btnBlockedAppList != null)
            {
                btnBlockedAppList.Width = buttonWidth;
                btnBlockedAppList.Height = buttonHeight;
                btnBlockedAppList.Left = 0;
                btnBlockedAppList.Top = margin;
            }

            if (btnDayRanges != null && btnBlockedAppList != null)
            {
               btnDayRanges.Width = buttonWidth;
               btnDayRanges.Height = buttonHeight;
               btnDayRanges.Left = 0;
               btnDayRanges.Top = btnBlockedAppList.Bottom + margin;
            }

            if (btnGoogleCalendar != null && btnDayRanges != null)
            {
               btnGoogleCalendar.Width = buttonWidth;
               btnGoogleCalendar.Height = buttonHeight;
               btnGoogleCalendar.Left = 0;
               btnGoogleCalendar.Top = btnDayRanges.Bottom + margin;
            }
        }

        private void BackButton_Clicked(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BlockedAppsButton_Clicked(object? sender, EventArgs e)
        {
            if (blockedApps == null || blockedApps.IsDisposed)
            {
                blockedApps = new BlockedApps();
                blockedApps.FormClosing += BlockedApp_FormClosing;
            }

            blockedApps.StartPosition = FormStartPosition.Manual;
            blockedApps.Location = this.Location;
            blockedApps.Size = this.Size;
            blockedApps.Show();
            Hide();
        }

        private void BlockedApp_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

            Location = blockedApps?.Location ?? Location;
            Size = blockedApps?.Size ?? Size;
            Show();
            blockedApps?.Hide();
        }
    }
}
