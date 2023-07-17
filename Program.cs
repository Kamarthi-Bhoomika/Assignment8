using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Salary
    {
        public double calc_salary(double wHour, double wDays,double projectHandle=1, double extras=0)
        {
            double sal = wHour * wDays *100 + projectHandle*3000 + extras*2000;
           
            return sal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            Console.WriteLine("HR: "+salary.calc_salary(8,30));
            Console.WriteLine("Admin: "+salary.calc_salary(8,30,2));
            Console.WriteLine("Software Developer: "+salary.calc_salary(8,30,3,1));
            Console.ReadKey();
        }
    }
}
