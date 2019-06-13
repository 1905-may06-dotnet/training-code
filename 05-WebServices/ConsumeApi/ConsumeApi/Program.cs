
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsumeApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Install-Package Microsoft.AspNet.WebApi.Client
            //2. create instance of http client
            using (HttpClient client=new HttpClient())
            {
                //3. create the URL that needs to used to access the resource
                client.BaseAddress = new Uri("https://localhost:44334/contact/");
                //4. call the controller which has action to provide resource
                var response=client.GetAsync("values");
                //5. Async tasks needed to be awaited
                response.Wait();
                //6. Get the result set
                var result=response.Result;
                //7. Check for the Status code if its ok
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine("Successfully got the response");
                    //Deserialize the Json object to the data object
                    var data=result.Content.ReadAsAsync<IEnumerable<User>>();
                    data.Wait();
                    //get deserialized results
                    var users=data.Result;
                    //iterate over the results
                    foreach (var user in users)
                    {
                        Console.WriteLine($"{user.Id} {user.firstName} {user.lastName}");
                    }
                }

            }
        }
    }
}
