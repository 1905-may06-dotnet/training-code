using System;
using System.Collections;//for non-Generic
using System.Collections.Generic;
namespace CollectionsDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            //1. Non-Generic Collections
            #region ArrayList
            /*ArrayList names = new ArrayList();
            names.Add("David Fay");
            names.Add("Fred Belotte");
            names.Add("Cameron Coley");
            names.Add("Julie Seals");
            //names.Remove("Fred Belotte");
            names.RemoveAt(1);
            names.Insert(1, "Avery Rose");
            Console.WriteLine($"Count of names:{names.Count}");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }*/
            #endregion
            #region Stack
            /* Stack calls = new Stack();
             calls.Push("9874563212");
             calls.Push(8784513212);
             calls.Push(57654531.32M);
             calls.Push('a');
             calls.Push(null);
             calls.Push("9879876431");
             Console.WriteLine($"Total items in Call stack {calls.Count}");
             Console.WriteLine("Items before Pop()---");
             foreach (var call in calls)
             {
                 Console.WriteLine(call);
             }
             Console.WriteLine("---Items After Pop()");
             Console.WriteLine(calls.Pop());
             Console.WriteLine("------------");
             foreach (var call in calls)
             {
                 Console.WriteLine(call);
             }*/
            #endregion
            #region Queue
            /*  Queue q = new Queue();
              q.Enqueue("1231");
              q.Dequeue();*/
            #endregion
            #region Hashtable
            /*Hashtable employees = new Hashtable();
            employees.Add("HR", "Avery Rose");
            employees.Add("Retention Coordinator", "Cameron Coley");
            employees.Add("Trainer", "Fred Belotte");
            employees.Add("Staging", "Julie Seals");
            
            foreach (var employee in employees.Keys)
            { 
                Console.WriteLine($"{employee} - {employees[employee]}");
            }*/
            #endregion

            //2. Generic Collections
            List<int> nums = new List<int>();
            nums.Add(45);
            Stack<string> st;
            Queue<string> qs;
            Dictionary<int, string> dt;

        }
    }
}
