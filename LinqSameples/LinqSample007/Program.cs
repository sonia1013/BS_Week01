using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
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
            int index = 1;
            //代表尋找list中索引的第[index]人
            var list = CreateList();
            var person1 = list.ElementAtOrDefault(index);
            //判斷結果是否為null
            if (person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引{index}的人是{person1.Name}-{person1.Age}");
            }
            Console.ReadKey();
        }
    }
}
