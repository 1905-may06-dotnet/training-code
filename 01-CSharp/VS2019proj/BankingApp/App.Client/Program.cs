using System;
using App.Logic;

namespace App.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverseStr = LogicClass.ReverseStr("Hello");
            Console.WriteLine(reverseStr);
        }

    }
}
