using System;

namespace PRACTICAL_2
{
    // Interface defined at namespace level
    interface Ipayrol
    {
        void calcSal();
    }

    // Base class
    class emp
    {
        public int empid;
        public string ename;
        public double bsal;

        public emp()
        {
            Console.WriteLine("************");
            Console.WriteLine("EMPLOYEE PAYROLL SYSTEM");
            Console.WriteLine("************");
        }

        public void acceptdet()
        {
            Console.WriteLine("Enter emp id:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name:");
            ename = Console.ReadLine();
            Console.WriteLine("enter basic salary:");
            bsal = Convert.ToDouble(Console.ReadLine());
        }

        public void dispdet()
        {
            Console.WriteLine("employee id=" + empid);
            Console.WriteLine("employee name=" + ename);
            Console.WriteLine("employee basic salary=" + bsal);
        }
    }

    // Derived class: Full-Time Employee
    class fullTimeemp : emp, Ipayrol
    {
        public void calcSal()
        {
            double da = bsal * 0.20;
            double hra = bsal * 0.50;
            double ma = bsal * 0.35;
            double pf = bsal * 0.60;

            double netsal = (bsal + da + ma + hra) - pf;
            Console.WriteLine("EMPLOYEE TYPE = FULL - TIME");
            Console.WriteLine("Net Salary= " + netsal);
        }
    }

    // Derived class: Part-Time Employee
    class partTimeemp : emp, Ipayrol
    {
        public void calcSal()
        {
            double netsal = bsal;
            Console.WriteLine("EMPLOYEE TYPE= PART-TIME");
            Console.WriteLine("Net Salary=" + netsal);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Type of Emp");
            Console.WriteLine("1.Full-Time");
            Console.WriteLine("2.Part-Time");

            Console.Write("Enter type=");
            int ch = Convert.ToInt32(Console.ReadLine());

            emp e = null;
            Ipayrol payrol = null;

            if (ch == 1)
            {
                fullTimeemp ft = new fullTimeemp();
                e = ft;
                payrol = ft;
            }
            else if (ch == 2)
            {
                partTimeemp pt = new partTimeemp();
                e = pt;
                payrol = pt;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            e.acceptdet();
            e.dispdet();
            payrol.calcSal();
        }
    }
}