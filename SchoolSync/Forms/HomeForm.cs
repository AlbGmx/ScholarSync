using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using SchoolSync.Forms;

namespace SchoolSync
{
    public partial class HomeForm : Form
    {

        private readonly UserCredential? userCredential;
        private readonly CalendarService? service;

        bool sidebarMenuExpanded = false;

        BlockedAppsForm? blockedAppsForm;
        SettingsForm? settingsForm;
        GoogleAccountForm? googleAccountForm;

        public HomeForm()
        {
            InitializeComponent();
            userCredential = GoogleAPI.GoogleAuth();
            service = GoogleAPI.CreateCalendarService(userCredential);
        }

        private void HomeForm_Load(object? sender, EventArgs e)
        {
            calendarWebView.Source = new Uri("https://calendar.google.com/calendar/");
        }

        private void SidebarMenuTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarMenuExpanded == false)
            {
                sidebarMenu.Width += 10;
                homePanel.Location = new Point(sidebarMenu.Width, 0);
                if (sidebarMenu.Width >= sidebarMenu.MaximumSize.Width)
                {
                    sidebarMenuExpanded = true;
                    sidebarMenuTimer.Stop();
                }
            }
            else
            {
                sidebarMenu.Width -= 10;
                if (sidebarMenu.Width <= sidebarMenu.MinimumSize.Width)
                {
                    sidebarMenuExpanded = false;
                    sidebarMenuTimer.Stop();
                }
            }
            homePanel.Location = new Point(sidebarMenu.Width, 0);
        }

        private void MenuControl_Clicked(object sender, EventArgs e)
        {
            sidebarMenuTimer.Start();
        }

        private void NoAllowedAppsControl_Clicked(object sender, EventArgs e)
        {
            if (blockedAppsForm == null)
            {
                blockedAppsForm = new BlockedAppsForm();
                blockedAppsForm.FormClosed += BlockedApps_FormClosed;
                blockedAppsForm.MdiParent = this;
                blockedAppsForm.Dock = DockStyle.Fill;
                blockedAppsForm.Show();
            }
            else
            {
                blockedAppsForm.Activate();
            }
        }

        private void BlockedApps_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void SettingsControl_Clicked(object sender, EventArgs e)
        {
            homePanel.Controls.Clear();
            settingsForm = new SettingsForm()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            homePanel.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void SettingsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void GoogleAccountControl_Clicked(object? sender, EventArgs e)
        {
            if (googleAccountForm == null)
            {
                googleAccountForm = new GoogleAccountForm();
                googleAccountForm.FormClosed += GoogleAccountForm_FormClosed;
                googleAccountForm.MdiParent = this;
                googleAccountForm.Dock = DockStyle.Fill;
                googleAccountForm.Show();
            }
            else
            {
                googleAccountForm.Activate();
            }
        }

        private void GoogleAccountForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void HomeForm_SizeChanged(object? sender, EventArgs e)
        {
            homePanel.Size = new Size(Width - sidebarMenu.Width, Height);
            calendarWebView.Size = homePanel.Size;
        }
    }
}
