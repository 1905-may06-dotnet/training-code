using System;
using BusinessLogic;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankOfAmerica boa = new RevatureCompany();//Upcasting
            boa.CreditScore = 7.5M;
            boa.Offer(boa.CreditScore);            
        }
    }
}
