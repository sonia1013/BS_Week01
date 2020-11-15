using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("請輸入年份:");
            year = Int32.Parse(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("這年是閏年");
            }
            else
            {
                Console.WriteLine("這年不是閏年");
            }
            Console.ReadLine();

        }
    }
}
