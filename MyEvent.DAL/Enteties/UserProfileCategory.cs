using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class UserProfileCategory
    {
        public int UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
