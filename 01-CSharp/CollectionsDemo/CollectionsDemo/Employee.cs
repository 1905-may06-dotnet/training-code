using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    // POCO- Plain Old CLR Objects
    partial class Employee
    {
        public int empId { get; set; }
        public string firstName {get;set;}
        public string lastName {get;set;}
        public string ssn {get;set;}
        public decimal salary { get; set; }
    }
}
