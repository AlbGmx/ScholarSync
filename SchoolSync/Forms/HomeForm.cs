using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using SchoolSync.Forms;

namespace SchoolSync
{
    public partial class HomeForm : Form
    {

        private readonly UserCredential userCredential;
        private readonly CalendarService service;

        bool sidebarMenuExpanded = false;

        BlockedAppsForm blockedAppsForm;
        SettingsForm settingsForm;
        GoogleAccountForm googleAccountForm;

        public HomeForm()
        {
            InitializeComponent();
            userCredential = GoogleAPI.GoogleAuth();
            service = GoogleAPI.CreateCalendarService(userCredential);
            CalendarWebView();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void CalendarWebView()
        {
            webView2.Name = "webView2";
            webView2.Source = new Uri("https://calendar.google.com/calendar/");
        }

        private void sidebarMenuTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarMenuExpanded == false)
            {
                sidebarMenu.Width += 10;
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
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarMenuTimer.Start();
        }

        private void btnNoAllowedApps_Click(object sender, EventArgs e)
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
            blockedAppsForm = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                settingsForm.FormClosed += SettingsForm_FormClosed;
                settingsForm.MdiParent = this;
                settingsForm.Dock = DockStyle.Fill;
                settingsForm.Show();
            }
            else
            {
                settingsForm.Activate();
            }
        }

        private void SettingsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            settingsForm = null;
        }

        private void btnGoogleAccount_Click(object sender, EventArgs e)
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
            googleAccountForm = null;
        }
    }
}
