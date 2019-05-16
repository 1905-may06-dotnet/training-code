using System;
using RestaurantData.Data;
using System.Collections.Generic;
using System.Text;

namespace RestaurantData
{
    public interface ICrud
    {
        List<Restaurant> GetRestaurants();
        Restaurant GetRestaurants(int id);

        void AddRestaurant(Restaurant r);
        void DeleteRestaurant(Restaurant r);
    }
}
