using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSync
{
    internal class GoogleAPI
    {
        static readonly string[] Scopes = [CalendarService.Scope.CalendarReadonly];

        public static UserCredential GoogleAuth()
        {
            UserCredential credential;
            using (var stream = new FileStream("C:\\Users\\pablo\\OneDrive\\Escritorio\\Projecto Test\\SchoolSync\\SchoolSync\\credentials.json", FileMode.Open, FileAccess.Read))
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

        public static Events GetEvents(CalendarService service, int goingBackDays, int goingForwardDays)
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
        public static CalendarService CreateCalendarService(UserCredential credential)
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Scholar Sync",
            });

            return service;
        }


    }
}
