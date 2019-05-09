using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
   public interface ICreditCard
    {
        decimal CreditScore { get; set; }
    }
   public interface IBankOfAmerica : ICreditCard
    {
        bool Offer(decimal CreditScore);
    }
    public interface IChaseBank : ICreditCard
    {
        bool Offer(decimal CreditScore);
    }
}
