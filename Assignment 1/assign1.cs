using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Jem",41000,5);
            Employee o2 = new Employee("Noah",50000, 2);
            Employee o3 = new Employee();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();
        }
    }

    class Employee
    {
        private string name;
        public string NAME
        {
           set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private static int empCount = 0;
        private int empNo;
        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        private decimal basic;
        public decimal BASIC
        {
           set
            {
                if (10000 <= value && value >= 100000)
                    basic = value;
            }
            get
            {
                return basic;
            }
        }

        private short deptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid Department number");
            }
            get
            {
                return deptNo;
            }
        }

        public decimal netSalary()
        {
            return basic * 12;
        }

        public Employee(string NAME = "MJ", decimal BASIC = 15000, short DEPTNO = 2)
        {
            empNo = ++empCount;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;
        }
    }
}
