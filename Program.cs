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
            Console.WriteLine("***********************************");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.WriteLine("***********************************");
            Console.Write("Enter choice to calculate salary: ");
            int ch = int.Parse(Console.ReadLine());
            double projectHandle, wHours, wDays, extras;

            Salary salary = new Salary();
            switch (ch)
            {
                case 1:
                    {
                        Console.Write("Enter working Hour: ");
                        wHours = double.Parse(Console.ReadLine());
                        Console.Write("Enter working Days: ");
                        wDays = double.Parse(Console.ReadLine());
                        Console.WriteLine("HR Monthly Salary: " + salary.calc_salary(wHours, wDays));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter working Hour: ");
                        wHours = double.Parse(Console.ReadLine());
                        Console.Write("Enter working Days: ");
                        wDays = double.Parse(Console.ReadLine());
                        Console.Write("Enter Project Handles: ");
                        projectHandle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Admin Monthly Salary: " + salary.calc_salary(wHours, wDays, projectHandle));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter working Hour: ");
                        wHours = double.Parse(Console.ReadLine());
                        Console.Write("Enter working Days: ");
                        wDays = double.Parse(Console.ReadLine());
                        Console.Write("Enter Project Handles: ");
                        projectHandle = double.Parse(Console.ReadLine());
                        Console.Write("Enter Extras: ");
                        extras = double.Parse(Console.ReadLine());
                        Console.WriteLine("Software Developers Monthly Salary: " + salary.calc_salary(wHours, wDays, projectHandle, extras));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
