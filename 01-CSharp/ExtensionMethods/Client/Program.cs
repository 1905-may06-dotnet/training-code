using System;
using Arithmatic;

namespace Client
{
    static class ExtendingMathLogic
    {
        public static double CircleArea(this MathLogic m, double r)
        {
            return Math.PI * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathLogic m = new MathLogic();
            m.CircleArea(5.5);
            m.Add(45, 65);
        }
        
    }
}
