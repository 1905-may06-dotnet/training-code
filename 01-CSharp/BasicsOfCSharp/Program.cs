//Namespace - logical collection of libraries
//1. Predefined name space
using System; 

//2. User Defined namespace
namespace BasicsOfCSharp
{
    //Types : Class, Structs, Enums, interfaces, Delegates
    class Program
    { 
        //Ctrl + K + C-> Comment 
        //Ctrl + K + U -> uncomment
        //Type Members: Methods, Variables, Constants, Properties
        static string name= "";
        /// This is the entry point to the program
        static void Main(string[] args)
        {
            /* Console.Write("Please Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Hello "+name); */

           // Employee emp=new Employee(); // default Constructor
            // emp.firstName="Carol";
            // emp.lastName="Baxtor";
            // emp.ssn="2342Ahjghj";
            // emp.age=40;
            // emp.salary=10000.00M; 
            // emp.ishuman=false; //cannot be  re assigned 
            //emp.GetDetails();
            /// Calling parametrized Constructor with name parameters
            //Employee emp=new Employee(age:29,firstName:"Palmer",lastName:"Calgoris",ssn:"hjhjk45",salary:8500.00M); // parameterised Constructor
           
           // Calling parameterized Constructor with default values
           Employee emp=new Employee("Felice","Sumargo","21321vhj");
           emp._Salary=8563.23M;
           Console.Write($"The Salary is {emp._Salary}");
        }
    }
}
