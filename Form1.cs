using Microsoft.Web.WebView2.WinForms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace ScholarSync
{
    public partial class Form1 : Form
    {
        static readonly string[] Scopes = [CalendarService.Scope.CalendarReadonly];
        static readonly string ApplicationName = "Scholar Sync";
        private WebView2 webView2;
        private ToolStrip toolStrip;
        private ToolStripButton settingsButton;
        private readonly UserCredential userCredential;
        private readonly CalendarService service;
        private readonly Events events;
        private readonly int goingBackDays = 7;
        private readonly int goingForwardDays = 7;
        private readonly int toolStripHeight = 25;


        public Form1()
        {
            InitializeComponent();
            webView2 = new WebView2();
            toolStrip = new ToolStrip();
            settingsButton = new ToolStripButton();

            InitializeToolStrip();
            userCredential = GoogleAuth();
            service = CreateCalendarService(userCredential);
            events = GetEvents(service, goingBackDays, goingForwardDays);
            InitializeCalendarWebView();
            this.Resize += new EventHandler(WebViewResize);
        }

        private void WebViewResize(object? sender, EventArgs e)
        {
            webView2.Size = new Size(ClientSize.Width, ClientSize.Height - toolStripHeight);
        }

        private void InitializeCalendarWebView()
        {
            webView2 = new WebView2
            {
                Location = new Point(0, toolStripHeight),
                Name = "webView2",
                TabIndex = 0,
                Size = new Size(ClientSize.Width, ClientSize.Height - toolStripHeight),
                Source = new Uri("https://calendar.google.com/calendar/")
            };
            Controls.Add(webView2);
        }

        private void InitializeToolStrip()
        {
            toolStrip = new ToolStrip
            {
                Height = toolStripHeight
            };
            
            settingsButton = new ToolStripButton
            {
                Text = "Settings",
                Name = "settingsButton",
                Size = new Size(toolStripHeight, toolStripHeight*10),
                Image = new Bitmap("settings.png"),
                DisplayStyle = ToolStripItemDisplayStyle.Image
            };

            toolStrip.Items.AddRange(new ToolStripItem[] { settingsButton });
            settingsButton.Click += new EventHandler(ClickedSettingsButton);
            Controls.Add(toolStrip);
        }

        private void ClickedSettingsButton(object? sender, EventArgs e)
        {
            // Open your settings form or handle settings logic here
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
            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        private static Events GetEvents(CalendarService service, int goingBackDays, int goingForwardDays)
        {

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMinDateTimeOffset = DateTimeOffset.Now.AddDays(goingBackDays * -1);
            request.TimeMinDateTimeOffset = DateTimeOffset.Now.AddDays(goingForwardDays);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            return events;
        }
    }
}
