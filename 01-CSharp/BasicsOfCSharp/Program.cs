//Namespace - logical collection of libraries
//1. Predefined name space
using System; 

//2. User Defined namespace
namespace BasicsOfCSharp
{
    //Types : Class, Structs, Enums, interfaces, Delegates
    class Program
    {
        //Type Members: Methods, Variables, Constants, Properties
        static string name= "";
        static void Main(string[] args)
        {
            Console.Write("Please Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Hello "+name);
        }
    }
}
