using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class User : IdentityUser
    {
        public int ProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
