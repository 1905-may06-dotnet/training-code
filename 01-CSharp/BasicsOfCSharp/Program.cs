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

            Employee emp=new Employee();
            emp.firstName="Carol";
            emp.lastName="Baxtor";
            emp.ssn="2342Ahjghj";
            emp.age=40;
            emp.salary=10000.00M; 

            emp.GetDetails();
        }
    }
}
