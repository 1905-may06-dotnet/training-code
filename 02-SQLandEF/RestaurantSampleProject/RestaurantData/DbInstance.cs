using RestaurantData.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantData
{
   public sealed class DbInstance
    {
        private static RestaurantContext instance = null;
        private DbInstance()
        {

        }
        public static RestaurantContext Instance { get {
                if (instance ==null)
                {
                    instance = new RestaurantContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }

    }
}
