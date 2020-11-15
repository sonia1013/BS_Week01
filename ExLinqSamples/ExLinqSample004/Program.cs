﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };

            var aEXb = list1.Except(list2);
            Console.WriteLine($"list1差集list2的結果為:");
            foreach (var item in aEXb)
            {
                Console.WriteLine(item);
            }

            var bEXa = list2.Except(list1);
            Console.WriteLine($"list2差集list1的結果為:");
            foreach (var item in bEXa)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
