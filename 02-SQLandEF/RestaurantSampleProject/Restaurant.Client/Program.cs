using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantData;
using RestaurantData.Data;

namespace Restaurant.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Crud d = new Crud();
            var restaurants=d.GetRestaurants();
            foreach (var r in restaurants)
            {
                Console.WriteLine(r.Name);
            }
           //Console.WriteLine(GetRestaurants(2).Name);
            /* foreach (var r in GetRestaurants())
             {
                 Console.WriteLine(r.Name);
             }*/

           // var r = new RestaurantData.Data.Restaurant() {Name="Cantinna"};
           // AddRestaurant(r);
        }
        
    }
}
