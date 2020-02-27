using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class Category
    {
        public int  Id { get; set; }

        public string Name { get; set; }
        public virtual IEnumerable<UserProfileCategory> UserProfileCategories { get; set; }
        public virtual IEnumerable<CategoryEvent> CategoryEvents { get; set; }
    }
}
