using System;
using System.Collections.Generic;

namespace RestaurantData.Data
{
    public partial class Review
    {
        public int Id { get; set; }
        public double? Rating { get; set; }
        public string Comment { get; set; }
        public int? RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
