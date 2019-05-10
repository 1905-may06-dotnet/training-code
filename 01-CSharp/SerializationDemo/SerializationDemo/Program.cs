using System;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() {
                empId = 123,
                empType = EmployeeType.FullTime,
                age = 40,
                name="Fred Belotte",
                salary = 456123.12M
            };

            var json=JsonHelper.JsonSerializer<Employee>(emp1);
            Console.WriteLine(json);

            Employee obj=JsonHelper.JsonDeserialize<Employee>(json);
            Console.WriteLine(obj.name);
        }
    }
}
