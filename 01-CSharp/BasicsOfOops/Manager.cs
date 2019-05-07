namespace BasicsOfOops
{
    class Manager : Employee
    {
        decimal perks;
        public Manager(string name, string ssn, int age, string empid, decimal bsal, decimal hra, decimal bonus,decimal perks)
        :base(name,ssn,age,empid,bsal,hra,bonus)
        {
            this.name = name;
            this.ssn = ssn;
            this.empid = empid;
            this.age = age;
            this.bsal = bsal;
            this.tax = 0.4M * bsal;
            this.bonus = bonus;
            this.hra = hra;
            this.perks=perks;
        }
        public override decimal GetSalary(){
            return base.salary= base.bsal+base.hra+base.bonus+perks-base.tax;
        }
    }
}