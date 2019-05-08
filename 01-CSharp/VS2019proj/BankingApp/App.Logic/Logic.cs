using System;

namespace App.Logic
{
    public class LogicClass
    {
        public static string ReverseStr(string str)
        {
            string temp = "";
            foreach (var cr in str)
            {
                //prepend of the chararcter
                temp = cr + temp;
            }
            return temp;
        }
    }
}
