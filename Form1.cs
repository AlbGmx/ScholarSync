using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace ScholarSync
{
    public partial class Form1 : Form
    {
        static readonly string[] Scopes = [CalendarService.Scope.CalendarReadonly];
        static readonly string ApplicationName = "Google Calendar API .NET Quickstart";
        private WebView2 webView2;
        private ToolStrip toolStrip;
        private ToolStripButton settingsButton;

        public Form1()
        {
            InitializeComponent();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2(); // Initialize webView2
            toolStrip = new ToolStrip(); // Initialize toolStrip
            settingsButton = new ToolStripButton(); // Initialize settingsButton
            GoogleApi();
            InitializeWebView();
            InitializeToolStrip();
        }

        private void InitializeWebView()
        {
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.Location = new System.Drawing.Point(0, 25); // Adjusted to leave space for the toolbar
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(800, 575); // Adjust size as needed
            this.webView2.TabIndex = 0;
            this.webView2.Source = new Uri("https://calendar.google.com/calendar/");
            this.Controls.Add(this.webView2);
        }

        private void InitializeToolStrip()
        {
            this.toolStrip = new ToolStrip();
            this.settingsButton = new ToolStripButton();

            // 
            // toolStrip
            //
            this.toolStrip.Items.AddRange(new ToolStripItem[] { this.settingsButton });
            this.settingsButton.Click += new EventHandler(SettingsButton_Click);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // Open your settings form or handle settings logic here
            MessageBox.Show("Settings button clicked");
        }

        private static void GoogleApi()
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
                MessageBox.Show("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMinDateTimeOffset = DateTimeOffset.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                // Display only the first event as text in a MessageBox
                Event event1 = events.Items[0];
            }
            else
            {
            }
        }
    }
}
