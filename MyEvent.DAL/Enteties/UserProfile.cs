using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
   public class UserProfile
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime Birthday { get; set; }
        public String Gender { get; set; }


        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }

        public int? PhotoId { get; set; }
        public virtual Photo Avatar { get; set; }


        public virtual IEnumerable<UserProfileCategory> UserProfileCategories { get; set; }
        public virtual IEnumerable<UserProfileEvent> UserProfileEvents { get; set; }


        public virtual IEnumerable<Event> MyEvents { get; set; }
        public virtual IEnumerable<Message> Messages { get; set; }


        public bool Online { get; set; }
        public DateTime TimeLogin { get; set; }
    }
}
