using System;
using System.Collections.Generic;
using System.Linq;


namespace Restaurant.Domain
{
    public class RestaurantDb
    {
        List<Restaurant> restaurants;

        Address add1 = new Address() { street1 = "123", street2 = "Plaza America", city = "Reston", state = "VA", country = "US" };
        Reviews rev1 = new Reviews() { revid = 1, rid = 1, rating = 4.5f, comments = "decent restaurant" };
        Reviews rev2 = new Reviews() { revid = 2, rid = 1, rating = 3.5f, comments = "Not bad" };
        List<Reviews> reviews = new List<Reviews>();
        public List<Restaurant> GetRestaurants()
        {
            //logic to get restarants
        }
    }
    public class RestaurantLogic
    {
        public List<Restaurant> GetBest()
        {
            //Logic to get best rating restuarant
            RestaurantDb db = new RestaurantDb();
            var res = db.GetRestaurants();
            //LINQ
            
            return res;
        }
    }
}
