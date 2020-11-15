using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample006
{

    class MyData
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static List<MyData> CreateList()
        {
            return new List<MyData>()
                {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill", Age = 35 },
                };
        }
        static void Main(string[] args)
        {
            var list = CreateList();
            var person1 = list.FirstOrDefault((x) => x.Name == "李小龍");
            //因為沒有這個人所以一定會發生例外狀況
            //判斷結果是否為null
            if (person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到{person1.Name}={person1.Age}");
            }
            Console.ReadKey();
        }
    }
}
