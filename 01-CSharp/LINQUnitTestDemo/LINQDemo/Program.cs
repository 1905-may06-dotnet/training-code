using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> emp =new List<string>() {"Carol","David","Fred","Julie" };
            /*var filteredEmps = from e in emp
                               where e.Contains('a')
                               select e;*/

            //LINQ-Query Syntax
            /* List<Employee> emp = new List<Employee>()
            {
                new Employee(){empId=123,age=25,country="US",name="Fred", bsal=500000.54M,hra=789.45M },
                new Employee(){empId=112,age=32,country="Uganda",name="Knuckles",bsal=123465.45M,hra=6565.20M},
                new Employee(){empId=111,age=45,country="US",name="David Fay",bsal=456123.45M,hra=1231.12M},
                new Employee(){empId=789,age=17,country="Canada",name="Daisy",bsal=45000.54M,hra=1000.50M}
            };
            var filteredEmps = from e in emp
                               where e.age > 20 && e.country=="US"
                               select e;*/
            //LINQ - Method Syntax
            // var filteredEmps = emp.Where(a => a.age > 20 && a.country == "US");//.Max(s=>s.age);//.FirstOrDefault();
            // Console.WriteLine(filteredEmps);
            /*foreach (var i in filteredEmps)
            {
                Console.WriteLine(i.name);
            }*/
        }
    }
    public class Employee
    {
        public int empId { get; set; }
        public int age { get; set; }
        public string  country { get; set; }
        public string  name { get; set; }

        public decimal bsal { get; set; }
        public decimal hra { get; set; }

        public decimal Salary(Employee emp)
        {
            return emp.hra + emp.bsal - (0.4M * emp.bsal);
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){empId=123,age=25,country="US",name="Fred", bsal=500000.54M,hra=789.45M },
                new Employee(){empId=112,age=32,country="Uganda",name="Knuckles",bsal=123465.45M,hra=6565.20M},
                new Employee(){empId=111,age=45,country="US",name="David Fay",bsal=456123.45M,hra=1231.12M},
                new Employee(){empId=789,age=17,country="Canada",name="Daisy",bsal=45000.54M,hra=1000.50M}
            };
            return emp;
        }
    }
}
