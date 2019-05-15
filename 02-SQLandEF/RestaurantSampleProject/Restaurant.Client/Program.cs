using Restaurant.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetRestaurants(2).Name);
            /* foreach (var r in GetRestaurants())
             {
                 Console.WriteLine(r.Name);
             }*/

            var r = new Restaurant.Data.Model.Restaurant() {Name="Cantinna"};
            AddRestaurant(r);
        }
        static List<Restaurant.Data.Model.Restaurant> GetRestaurants()
        {
            RestaurantDbContext db = new RestaurantDbContext();
            // var restaurants=  from r in db.Restaurant
            //select r;

            var restaurants = db.Restaurant.ToList();
            return restaurants;
        }

        static Restaurant.Data.Model.Restaurant GetRestaurants(int id)
        {
            RestaurantDbContext db = new RestaurantDbContext();
            // var restaurants=  from r in db.Restaurant
            //select r;

            var restaurant = db.Restaurant.Where<Restaurant.Data.Model.Restaurant>(r => r.Id == id).FirstOrDefault();
            return restaurant;
        }

        static void AddRestaurant(Restaurant.Data.Model.Restaurant r)
        {
            RestaurantDbContext db = new RestaurantDbContext();
            db.Restaurant.Add(r);// calling insert Query
            db.SaveChanges();
            Console.WriteLine($"Restaurant {r.Name} added into Db");
        }
    }
}
