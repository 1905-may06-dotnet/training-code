using System;

namespace BasicsOfCSharp{
class Employee //Proper
 {
     //variables - camelCase
     internal string firstName, lastName, ssn;
     internal int age;
     internal decimal salary;

     //Methods= Specification + definition (body)
     public void GetDetails(){
        // Console.WriteLine("Name {0} {1} has Social Security - {2}. The Salary is {3}.",firstName,lastName,ssn,salary);
         
         Console.WriteLine($"Name {firstName} {lastName} has Social Security - {ssn}. The Salary is {salary}.");
     }

 }    
}