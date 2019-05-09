using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    partial class Employee
    {
        public List<Employee> GetEmployees()
        {
            //List<Employee> employees;//declaration or creation of reference variable
            //employees = new List<Employee>();//instantiation or initialization

            /* Employee emp1 = new Employee();
             emp1.empId = 123;
             emp1.firstName = "Fred";
             emp1.lastName = "Belotte";
             emp1.salary = 7896546556.2123M;
             emp1.ssn = "PS5";

             employees.Add(emp1);*/

            List<Employee> employees = new List<Employee>() {
                new Employee() { empId=123,firstName="Fred", lastName="Belotte", salary=456465.12M, ssn="PS5"},
                new Employee() { empId=456, firstName="Cameron", lastName="Coley", salary=1235.11M,ssn="XBOX"}
            };
            return employees;

        }
    }
}
