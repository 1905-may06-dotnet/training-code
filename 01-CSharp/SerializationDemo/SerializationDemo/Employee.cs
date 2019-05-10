using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SerializationDemo
{
    enum EmployeeType
    {
        FullTime,
        PartTime,
        Contractor
    }
    [DataContract]// this means that this class can be serialized to Json string
    class Employee
    {
        [DataMember]
        public int empId { get; set; }
        [DataMember]
        public string  name { get; set; }
        [DataMember]
        public int age { get; set; }
        public EmployeeType empType { get; set; }
        public decimal salary { get; set; }


    }
}
