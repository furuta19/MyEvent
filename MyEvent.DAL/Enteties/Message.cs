using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class Message
    {
        public int Id { get; set; }

        public int InternalId { get; set; }

        public string MessageText { get; set; }
        public virtual DateTime MessageTime { get; set; }

        public int UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
