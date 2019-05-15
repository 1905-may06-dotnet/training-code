using System;
using System.Collections.Generic;

namespace Restaurant.Data.Model
{
    public partial class Review
    {
        public int Id { get; set; }
        public double? Rating { get; set; }
        public string Comment { get; set; }
        public int? RestaurantId { get; set; }

        //Navigation Property
        public virtual Restaurant Restaurant { get; set; }
    }
}
