using System;
namespace BasicsOfOops
{
    class Employee
    {
        protected string name, ssn, empid;
        protected int age;
        protected decimal salary;
        protected decimal bsal, bonus, tax, hra;
        public Employee()
        {
            
            Console.WriteLine("calling default constructror");
        }
        public Employee(string name, string ssn, int age, string empid, decimal bsal, decimal hra, decimal bonus = 10000.00M)
        {
            this.name = name;
            this.ssn = ssn;
            this.empid = empid;
            this.age = age;
            this.bsal = bsal;
            this.tax = 0.4M * bsal;
            this.bonus = bonus;
            this.hra = hra;
        }
        //Method overloading:  Methods with same name but different signatures:
        //1. number of paramenters
        //2. Type of parameters
        //3. Sequence of Parameters
        //public abstract decimal GetSalary();
        public virtual decimal GetSalary()
        {
            return salary = bsal + bonus + hra - tax;
        }
        #region Method overloads
        /* public decimal GetSalary(decimal ta){
             return salary=bsal+bonus+hra+ta-tax;
         }

         public decimal GetSalary(decimal ta, decimal perdiem){
             return salary=bsal+bonus+hra+ta+perdiem-tax;
         }
         public string GetSalary(string empid){
             return $"The salary of employee- {empid}is {bsal+bonus+hra-tax}";
         } */
        #endregion

    }
}