using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入以逗號分隔的數列:");
            string input = Console.ReadLine();
            string[] str = input.Split(',');
            int[] intstr = new int[str.Length];
            //再迴圈把str陣列中的字串轉換成int 型別
            for(int i =0;i<str.Length;i++)
            {
                intstr[i] = Int32.Parse(str[i]);
            }
            
            for(int i=1;i<=intstr.Length;i++)
            {
                Console.Write((intstr[intstr.Length-i]).ToString()+",");
            }
            Console.ReadLine();
            //12,13,23,32
        }
    }
}
