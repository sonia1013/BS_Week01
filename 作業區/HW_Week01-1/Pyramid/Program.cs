using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數:");
            int num = Int32.Parse(Console.ReadLine());

            var a= new int[5];

            Console.WriteLine( a[^1] );

            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= num -i + 1; j++)
                {
                    //5
                    //44
                    //333
                    //2222
                    //11111
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
