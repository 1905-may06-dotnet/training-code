using System;
using System.Collections.Generic;

namespace RestaurantReviews.Context
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}
