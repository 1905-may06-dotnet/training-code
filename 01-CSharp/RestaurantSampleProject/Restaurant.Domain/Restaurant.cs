using System;
using System.Collections.Generic;

namespace Restaurant.Domain
{
    public class Address
    {
        public string  street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string  country { get; set; }
    }
    public class Restaurant
    {
        public int rId { get; set; }
        public string name { get; set; }
        public Address address { get; set; }

        public List<Reviews> reviews { get; set; }
    }
}
