using System;
using App.Logic;

namespace App.Client
{
    class Program //: LogicClass //implementing abstract class
    {
        static void Main(string[] args)
        {
            // string reverseStr = LogicClass.ReverseStr("Hello");
            // Console.WriteLine(reverseStr);

            // Calling Swap - call by value
            //int x = 10, y = 20;
            //int x, y;
            //Console.WriteLine($" Before Swapping x={x} and y={y}");
            // LogicClass.Swap(out int x,out int y);
            // Console.WriteLine($" after Swapping x={x} and y={y}");
            //multi values fields - can hold upto 8 items

            /*Tuple<int, int, string, char, char> tpl =
                new Tuple<int, int, string,char,char>(1, 2, "test",'A','B');
            var item = tpl.Item3;
            Console.WriteLine(item);*/

            var x = "54";
            var y = "89";
            Console.WriteLine($" Before Swapping x={x} and y={y}");
            LogicClass<string>.Swap<string>(ref x, ref y);
            Console.WriteLine($" after Swapping x={x} and y={y}");
        }
        /*public override void Test()
        {
            //code logic
        }*/

    }
}
