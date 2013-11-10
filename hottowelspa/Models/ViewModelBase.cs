using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hottowelspa.Models
{
    public class ViewModelBase
    {
        public IEnumerable<Notification> Notifications { get; set; }

        public IEnumerable<Notification> Errors
        {
            get
            {
                return Notifications.Where(n => n.Severity == NotificationSeverity.Error);
            }
        }

        public ViewModelBase()
        {
            this.Notifications = NotificationCollection.CreateEmpty();
        }
    }


    public static class NotificationCollection {
        public static List<Notification> CreateEmpty() {
            return new List<Notification>();
        }
    }


    public class Notification{

        public string Text {get; set;}

        public NotificationSeverity Severity {get; set;}

        public Notification(string message, NotificationSeverity severity)
        {
            Text = message;
            Severity = severity;
        }
    }


    public enum NotificationSeverity {
        Error,
        Warning,
        Message
    }
}