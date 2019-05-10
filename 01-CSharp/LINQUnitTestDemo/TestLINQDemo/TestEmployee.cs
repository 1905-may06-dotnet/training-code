using LINQDemo;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;//for Test Framework

namespace TestLINQDemo
{
    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void TestSalary()
        {
            //1. Arrange
            Employee emp = new Employee();
            //get the data to test
            var emps=emp.GetEmployees();
            var empMax = emps.Where(a => a.age > 20).OrderByDescending(s=>s.bsal).First();
            decimal expectedSalary= 300789.774M;
            //2. Act
            var ActualSalary=emp.Salary(empMax);
            //3. Assert
            Assert.AreEqual(expectedSalary, ActualSalary);
        }
    }
}
