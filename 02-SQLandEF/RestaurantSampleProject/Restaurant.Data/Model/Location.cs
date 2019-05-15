using System;
using System.Collections.Generic;

namespace Restaurant.Data.Model
{
    public partial class Location
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public int? RestaurantId { get; set; }
        //Navigation Properties
        public virtual Restaurant Restaurant { get; set; }
    }
}
