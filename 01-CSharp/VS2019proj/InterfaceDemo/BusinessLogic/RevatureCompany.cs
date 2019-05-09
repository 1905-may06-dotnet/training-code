using System;

namespace BusinessLogic
{
    public class RevatureCompany : IBankOfAmerica, IChaseBank
    {
        private decimal score;
        public decimal CreditScore {
            get {
                return score;
            }
            set {
                score = value;
            }
        }

        bool IBankOfAmerica.Offer(decimal CreditScore)
        {
            CreditScore = score;
            if (CreditScore>7)
            {
                Console.WriteLine("You have got the 20% discount");
                return true;
            }
            else
            {
                Console.WriteLine("Your Credit Score is less than 7 so  no offer");
                return false;
            }
        }

        bool IChaseBank.Offer(decimal CreditScore)
        {
            CreditScore = score;
            if (CreditScore > 6 && CreditScore < 7.5M)
            {
                Console.WriteLine("You have got the 15% discount");
                return true;
            }
            else if (CreditScore > 7.5M)
            {
                Console.WriteLine("You have got the 25% discount");
                return true;
            }
            else
            {
                Console.WriteLine("Your Credit Score is less than 7 so  no offer");
                return false;
            }
        }
    }
}
