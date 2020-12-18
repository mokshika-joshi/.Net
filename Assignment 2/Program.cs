using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager gm = new GeneralManager("John", 32, 50000, "Developer", "Transportation");
            Console.WriteLine(gm.Name);
            Console.WriteLine(gm.EmpNo);
            Console.WriteLine(gm.DeptNo);
            Console.WriteLine(gm.Basic);
            Console.WriteLine(gm.Designation);
            Console.WriteLine(gm.Perks);
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    Console.WriteLine("Enter Your Name");
                else
                    name = value;
            }
        }

        private int empNo;
        public static int empCount = 0;
        public int EmpNo
        {
            get { return empNo; }
        }

        private short deptNo;
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value == 0)
                    Console.WriteLine("Dept. number cannot be zero");
                else
                    deptNo = value;
            }
        }
        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }
        public Employee(String Name = "No-Name", short DeptNo = 100, decimal Basic = 10000)
        {

            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }

        public abstract decimal CalcNetSalary();
    }
    class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            get { return designation; }
            set
            {
                if (value == null)
                    Console.WriteLine("Designation cannot be blank");
                else
                    designation = value;
            }
        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 100000 && value < 1000000)
                    Console.WriteLine("Salary is High");
                else
                    basic = value;
            }
        }
        public Manager(String Name = "No-Name", short DeptNo = 100, decimal Basic = 10000, string Designation = "Default") : base(Name, DeptNo, Basic)
        {

            this.Designation = Designation;
        }

        public override decimal CalcNetSalary()
        {
            return 12 * basic;
        }



    }
    class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            get { return perks; }
            set
            {
                if (value == null)
                    Console.WriteLine("Perks cannot be blank");
                else
                    perks = value;
            }
        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 1000 && value < 10000)
                    Console.WriteLine("Salary is Low");
                else
                    basic = value;
            }
        }
        public GeneralManager(String Name = "No-Name", short DeptNo = 100, decimal Basic = 10000, string Designation = "Default", string Perks = "Default") : base(Name, DeptNo, Basic, Designation)
        {

            this.Perks = Perks;
        }
        public override decimal CalcNetSalary()
        {
            return (12 * basic) + 10000;
        }

    }
}
