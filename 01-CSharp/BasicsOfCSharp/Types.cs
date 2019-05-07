using System;

namespace BasicsOfCSharp{
class Employee //Proper
 {
    internal const bool ishuman=true;// Its value cannot be changed
     //variables - camelCase
     //Declaration of variables
     internal string firstName, lastName, ssn;
     internal int age;
     private decimal salary;

    //Properties: Smart fields to acccess the private variables outdide the class
    public decimal _Salary{
        get{
            if(salary>5000)
                return salary;
            else 
            return 0.00M;
        }
        //Read only property
       /* set{
                salary=value;
        } */
    }
     //Methods= Specification + definition (body)
     public void GetDetails(){
        // Console.WriteLine("Name {0} {1} has Social Security - {2}. The Salary is {3}.",firstName,lastName,ssn,salary);
         Console.WriteLine($"Name {firstName} {lastName} has Social Security - {ssn}. The Salary is {salary}.");
     }

     //Constructors in C# : Special methods which is used to initialize the memory to the objects
     //parameter less Constructor
     public Employee(){
            firstName="Cameron";
            lastName="Coley";
            ssn="123hhjkjk";
            age=30;
            salary=8000.00M; 
            Console.WriteLine($"Name {firstName} {lastName} has Social Security - {ssn}. The Salary is {salary}.");
     }
     //parameterized constructors
     public Employee(string firstName,string lastName, string ssn, int age=18, decimal salary=5000.50M )
     {
         this.firstName=firstName;
         this.lastName=lastName;
         this.age=age;
         this.ssn=ssn;
         this.salary=salary;
         Console.WriteLine($"Name {firstName} {lastName} has Social Security - {ssn}. The Salary is {salary}.");
     }

 }    
}