using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class Event
    {
        public int Id { get; set; }

        public string EventName { get; set; }
        public string EventText { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }


        public int? UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        public int? PhotoId { get; set; }
        public virtual Photo Photo { get; set; }

        public virtual IEnumerable<CategoryEvent> CategoryEvents { get; set; }
        public virtual IEnumerable<UserProfileEvent> UserProfileEvents { get; set; }

        public virtual IEnumerable<Message> Messages { get; set; }
    }
}
