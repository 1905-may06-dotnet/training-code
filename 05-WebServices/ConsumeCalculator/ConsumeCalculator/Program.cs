using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalculatorServiceReference;


namespace ConsumeCalculator
{
    class Program
    {
       static ArithmaticClient client = new ArithmaticClient();
        static void Main(string[] args)
        {
            //Console.WriteLine(GetResult().Result);
            var users=GetUsers().Result;
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.Email}");
            }
        }
        public static async Task<decimal> GetResult()
        {
           return await client.AddAsync(new decimal[]{ 12, 45, 65, 789, 85 });            
        }
        public static async Task<IEnumerable<User>> GetUsers()
        {
            return await client.GetUsersAsync();
        }

    }
}
