using System;
using System.Collections.Generic;

namespace Restaurant.Data.Model
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Location = new HashSet<Location>();
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
