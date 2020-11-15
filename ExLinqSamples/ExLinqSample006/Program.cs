using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample006
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultofSkip = list.Skip(3);
            Display(resultofSkip);
            var resultofTake = list.Take(3);
            Display(resultofTake);
            var resultofSkipTake = list.Skip(2).Take(2);
            Display(resultofSkipTake);

        }

        static void Display(IEnumerable<string> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
