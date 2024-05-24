
using Microsoft.Web.WebView2.WinForms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
namespace ScholarSync.Forms
{
    public partial class Home : Form
    {
        static readonly string[] Scopes = [CalendarService.Scope.CalendarReadonly];
        static readonly string APPLICATION_NAME = "Scholar Sync";
        private SettingsForm? settingsForm;
        private WebView2 webView2;
        private ToolStrip toolStrip;
        private ToolStripButton settingsButton;
        private readonly UserCredential userCredential;
        private readonly CalendarService service;
        private readonly Events events;
        private static readonly int DEFAULT_DAYS = 7;
        private static readonly int GOING_BACK_DAYS = DEFAULT_DAYS;
        private static readonly int GOING_FORWARD_DAYS = DEFAULT_DAYS;
        private static int TOOLSTRIP_HEIGHT = 25;


        public Home()
        {
            InitializeComponent();
            webView2 = new WebView2();
            toolStrip = new ToolStrip();
            settingsButton = new ToolStripButton();
            InitializeToolStrip();

            userCredential = GoogleAuth();
            service = CreateCalendarService(userCredential);
            events = GetEvents(service, GOING_BACK_DAYS, GOING_FORWARD_DAYS);
            InitializeCalendarWebView();
            
            Resize += new EventHandler(View_Resize);
        }

        private void View_Resize(object? sender, EventArgs e)
        {
            webView2.Size = new Size(ClientSize.Width, ClientSize.Height - TOOLSTRIP_HEIGHT);
        }

        private void InitializeCalendarWebView()
        {
            webView2 = new WebView2
            {
                Location = new Point(0, TOOLSTRIP_HEIGHT),
                Name = "webView2",
                TabIndex = 0,
                Size = new Size(ClientSize.Width, ClientSize.Height - TOOLSTRIP_HEIGHT),
                Source = new Uri("https://calendar.google.com/calendar/")
            };
            Controls.Add(webView2);
        }

        private void InitializeToolStrip()
        {
            toolStrip = new ToolStrip
            {
                Height = TOOLSTRIP_HEIGHT,
                Width = ClientSize.Width,
            };

            settingsButton = new ToolStripButton
            {
                Text = "Settings",
                Name = "settingsButton",
                Size = new Size(TOOLSTRIP_HEIGHT, TOOLSTRIP_HEIGHT * 10),
                Image = new Bitmap("settings.png"),
                DisplayStyle = ToolStripItemDisplayStyle.Image
            };

            toolStrip.Items.AddRange(new ToolStripItem[] { settingsButton });
            settingsButton.Click += new EventHandler(SettingsButton_Clicked);
            Controls.Add(toolStrip);
        }

        private void SettingsButton_Clicked(object? sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                settingsForm.FormClosing += SettingsForm_FormClosing;
            }

            settingsForm.StartPosition = FormStartPosition.Manual;
            settingsForm.Location = this.Location;
            settingsForm.Size = this.Size;
            settingsForm.Show();
            Hide();
        }

        private void SettingsForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

            Location = settingsForm?.Location ?? Location;
            Size = settingsForm?.Size ?? Size;
            Show();
            settingsForm?.Hide();
        }

        private static UserCredential GoogleAuth()
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            return credential;
        }

        private static CalendarService CreateCalendarService(UserCredential credential)
        {
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = APPLICATION_NAME,
            });

            return service;
        }

        private static Events GetEvents(CalendarService service, int goingBackDays, int goingForwardDays)
        {
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMinDateTimeOffset = DateTimeOffset.Now.AddDays(goingBackDays * -1);
            request.TimeMaxDateTimeOffset = DateTimeOffset.Now.AddDays(goingForwardDays);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            Events events = request.Execute();
            return events;
        }
    }
}
