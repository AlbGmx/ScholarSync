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
            homePanel.Controls.Clear();
            blockedAppsForm = new BlockedAppsForm()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            homePanel.Controls.Add(blockedAppsForm);
            ShrinkSidebarMenu();
            blockedAppsForm.Show();
            returnControl.Show();
        }

        private void SettingsControl_Clicked(object? sender, EventArgs e)
        {
            homePanel.Controls.Clear();
            settingsForm = new SettingsForm()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            homePanel.Controls.Add(settingsForm);
            ShrinkSidebarMenu();
            settingsForm.Show();
            returnControl.Show();
        }

        private void GoogleAccountControl_Clicked(object? sender, EventArgs e)
        {
            homePanel.Controls.Clear();
            googleAccountForm = new GoogleAccountForm()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            homePanel.Controls.Add(googleAccountForm);
            ShrinkSidebarMenu();
            googleAccountForm.Show();
            returnControl.Show();
        }

        private void HomeForm_SizeChanged(object? sender, EventArgs e)
        {
            homePanel.Size = new Size(Width - sidebarMenu.Width, Height);
        }

        private void ReturnContol_Clicked(object? sender, EventArgs e)
        {
            homePanel.Controls.Clear();
            calendarWebView = new Microsoft.Web.WebView2.WinForms.WebView2()
            {
                Dock = DockStyle.Fill,
                Source = new Uri("https://calendar.google.com/calendar/u/0/r"),
            };
            homePanel.Controls.Add(calendarWebView);
            returnControl.Hide();
            calendarWebView.Show();
            ShrinkSidebarMenu();
        }

        private void ShrinkSidebarMenu()
        {
            if (sidebarMenuExpanded == true)
            {
                sidebarMenuTimer.Start();
            }
        }
    }
}
