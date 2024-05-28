using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using ScholarSync.Forms;
using SchoolSync.Forms;

namespace SchoolSync
{
    public partial class HomeForm : Form
    {
        private SettingsData? settingsData;
        public int? FromDate { get; set; }
        public int? UntilDate { get; set; }

        private readonly UserCredential? userCredential;
        private readonly CalendarService? service;

        bool sidebarMenuExpanded = false;

        BlockedAppsForm? blockedAppsForm;
        SettingsForm? settingsForm;
        GoogleAccountForm? googleAccountForm;

        public HomeForm()
        {
            InitializeComponent();
            sidebarMenu.Width = sidebarMenu.MinimumSize.Width;
            userCredential = GoogleAPI.GoogleAuth();
            service = GoogleAPI.CreateCalendarService(userCredential);
            LoadSettings();
            UpdateDaysCountLabels();
        }

        private void LoadSettings()
        {
            settingsData = Utils.LoadSettings();
            FromDate = settingsData.FromDate;
            UntilDate = settingsData.UntilDate;
        }

        private void SaveSettings()
        {
            SettingsData dataToSave = new()
            {
                FromDate = FromDate,
                UntilDate = UntilDate,
            };
            Utils.SaveSettings(dataToSave);
        }

        private void SidebarMenuTimer_Tick(object sender, EventArgs e)
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
            homePanel.Location = new Point(sidebarMenu.Width, homePanel.Location.Y);
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
            ReturnControl.Show();
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
            ShrinkSidebarMenu();
            settingsForm.ReceiveData(FromDate, UntilDate);
            LabelFromDate.Hide();
            LabelUntilDate.Hide();
            LabelUntilDateDescription.Hide();
            LabelFromDateDescription.Hide();
            settingsForm.Show();
            ReturnControl.Show();
        }

        private void GoogleAccountControl_Clicked(object? sender, EventArgs e)
        {
            homePanel.Controls.Clear();
            googleAccountForm = new GoogleAccountForm()
            {
                TopLevel = false,
                MdiParent = this,
                Dock = DockStyle.Fill,
            };
            homePanel.Controls.Add(googleAccountForm);
            ShrinkSidebarMenu();
            googleAccountForm.Show();
            ReturnControl.Show();
        }

        private void ReturnControl_Clicked(object? sender, EventArgs e)
        {
            Control control = homePanel.Controls[0];
            Type? currentFormType;
            if (control is Form form)
            {
                currentFormType = form.GetType();

                if (currentFormType.Name == "SettingsForm")
                {
                    int[] dataArray = settingsForm.GetFormData();
                    FromDate = dataArray[0];
                    UntilDate = dataArray[1];
                    LabelFromDate.Show();
                    LabelUntilDate.Show();
                    LabelUntilDateDescription.Show();
                    LabelFromDateDescription.Show();
                }
            }
            homePanel.Controls.Clear();
            calendarWebView = new Microsoft.Web.WebView2.WinForms.WebView2()
            {
                Dock = DockStyle.Fill,
                Source = new Uri("https://calendar.google.com/calendar/u/0/r"),
            };
            homePanel.Controls.Add(calendarWebView);
            ReturnControl.Hide();
            calendarWebView.Show();
            ShrinkSidebarMenu();
            UpdateDaysCountLabels();
        }

        private void UpdateDaysCountLabels()
        {
            if (FromDate != null && UntilDate != null)
            {
                LabelUntilDate.Text = UntilDate.ToString();
                LabelUntilDate.ForeColor = Color.Black;
                LabelFromDate.Text = FromDate.ToString();
                LabelFromDate.ForeColor = Color.Black;
            }
            else
            {
                LabelUntilDate.Text = SettingsForm.MINIMUM_DAY_DIFFERENCE.ToString();
                LabelUntilDate.ForeColor = Color.Red;
                LabelFromDate.Text = SettingsForm.MINIMUM_DAY_DIFFERENCE.ToString();
                LabelFromDate.ForeColor = Color.Red;
            }
        }

        private void ShrinkSidebarMenu()
        {
            if (sidebarMenuExpanded == true)
            {
                sidebarMenuTimer.Start();
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void HomeForm_SizeChanged(object? sender, EventArgs e)
        {
            homePanel.Size = new Size(Width - sidebarMenu.Width, Height);
        }

        private void testNotificationBtn_Click(object sender, EventArgs e)
        {
            NotificationForm notification = new NotificationForm();
            notification.Show();
        }
    }
}
