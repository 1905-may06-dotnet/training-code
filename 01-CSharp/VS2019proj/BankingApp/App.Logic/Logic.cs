using System;

namespace App.Logic
{
   // public abstract class LogicClass // abstract class
    public class LogicClass<T> : ILogic<T> // implement interface
    {
        int a;
        public int value {
            get { return a; }
            set { a = value; }
        }
        public static string ReverseStr(string str)
        {
            int? a;
            Nullable<int> b;
            string temp = "";
            foreach (var cr in str)
            { 
                //prepend of the chararcter
                temp = cr + temp;
            }
            return temp;
        }
        public void Swap<T1>(T1 a, T1 b)
        {
            (a, b) = (b, a);
        }
        //public abstract void Test();

        //public static void Swap(out int a, out int b)
        /*  public static void Swap(int a, int b)
          {
              //a = 5;
              //b = 6;
               int temp;
              temp = a;
              a = b;
              b = temp;
              (a, b) = (b, a); // tuples            
          }
          public static void Swap(string  a, string b)
          {
              string temp;
              temp = a;
              a = b;
              b = temp;            
          }*/

        /* public static void Swap<T>(ref T a,ref T b) 
            // where T : struct //constraint
             //where U: class
         {
             T temp;
             temp = a;
             a = b;
             b = temp;
             Console.WriteLine($"a={a} and type = {a.GetType()} and b={b} and type = {b.GetType()}");
         }*/
    }
}
