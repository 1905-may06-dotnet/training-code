using System;

namespace BasicsOfOops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp=new Employee("test1","123HJ45",45,"111",4500.00M,1200.00M);
           // Console.Write($"The salary is {emp.GetSalary(800.00M,75.00M)}");
           // upcasting 
            Employee emp=new Manager("Patrick Walsh","123456bhj",33,"123",12000.00M,600.00M,5000.500M,1000.00M);
            Console.Write($"The salary is {emp.GetSalary()}");

        }
    }
}
