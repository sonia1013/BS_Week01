using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數列:");
            string input = Console.ReadLine();
            string[] str = input.Split(',');

            //如何得到字串的長度
            int strlength = str.Length;
            

            int[] nums = new int[strlength];
            int x;

            for (int i = 0; i < str.Length; i++)
            {
                x = Int32.Parse(str[i]);
                nums[i] = x;
            }
            Console.WriteLine(nums.ToString());

            //foreach (int x in intstr)
            //{
            //    int[] Odd = new int[str.Length];
            //    int[] Even = new int[str.Length];


            //    Console.WriteLine(intstr);


            //    if (x % 2 != 0)
            //    {      
            //        //Odd[countOdd] = x;
            //        //countOdd += 1;

            //    }
            //    else
            //    {
            //        //Odd[countEven] = x;
            //        //countEven += 1;

            //    }
            //}

            Console.ReadLine();

            ///*8,7,9,3,11,6,2,18*/
            ///8
            ///7
            ///9
            ///3
        }
    }
}
