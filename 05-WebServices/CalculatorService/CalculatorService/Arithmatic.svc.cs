using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Arithmatic : IArithmatic
    {
        public decimal Add(params decimal[] values)
        {
            decimal result = 0;
            foreach (var num in values)
            {
                result += num;
            }
            return result;
        }

        public decimal Division(decimal numerator, decimal denominator)
        {
            if (denominator != 0)
                return numerator / denominator;
            else
                throw new DivideByZeroException("Denominator cannot be zero");
        }

        public decimal Multiply(params decimal[] values)
        {
            decimal result = 1;
            foreach (var num in values)
            {
                result *= num;
            }
            return result;
        }
        public List<User> GetUsers() {
            List<User> users =new List<User>{
                new User() { Id = 1, Email = "test@gmail.com", Name = "test" },
                new User() { Id = 2, Email = "test2@gmail.com", Name = "test2" }
            };
            return users;
        }
    }
}
