using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字:");
            int num=Int32.Parse(Console.ReadLine());
            if (num / 2 == 0)
            {
                Console.WriteLine("你輸入的數字為偶數");
            }
            else
            {
                Console.WriteLine("你輸入的數字為奇數");
            }
            Console.ReadLine();
        }
    }
}
