using RestaurantData.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantData
{
    public class Crud:ICrud
    {
       public List<Restaurant> GetRestaurants()
        {            
            // var restaurants=  from r in db.Restaurant
            //select r;

            var restaurants = DbInstance.Instance.Restaurant.ToList();
            return restaurants;
        }

        public Restaurant GetRestaurants(int id)
        {
           // RestaurantContext db = new RestaurantContext();
            // var restaurants=  from r in db.Restaurant
            //select r;

            var restaurant = DbInstance.Instance.Restaurant.Where<Restaurant>(r => r.Id == id).FirstOrDefault();
            return restaurant;
        }

        public void AddRestaurant(Restaurant r)
        {
            // RestaurantContext db = new RestaurantContext();
            DbInstance.Instance.Restaurant.Add(r);// calling insert Query
            DbInstance.Instance.SaveChanges();
            Console.WriteLine($"Restaurant {r.Name} added into Db");
        }
        public void DeleteRestaurant(Restaurant r) {
            //RestaurantContext db = new RestaurantContext();
            var restaurant= DbInstance.Instance.Restaurant.Where<Restaurant>(x => x.Id == r.Id).FirstOrDefault();
            DbInstance.Instance.Restaurant.Remove(restaurant);
            DbInstance.Instance.SaveChanges();
        }
    }
}
