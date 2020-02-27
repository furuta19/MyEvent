using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.DAL.Enteties
{
    public class CategoryEvent
    {
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
