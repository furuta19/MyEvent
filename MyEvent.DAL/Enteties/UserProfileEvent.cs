using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class UserProfileEvent
    {
        public int UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
