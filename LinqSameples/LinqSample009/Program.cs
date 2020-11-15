using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample009
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
            string Name = "Bill";
            bool isBill = list.All((x) => x.Name == Name);
            if (isBill)
            {
                Console.WriteLine($"找到此人{Name}");
            }
            else
            {
                Console.WriteLine($"沒有全部的人都叫{Name}");
            }
            

            bool isOverForty = list.All((x) => x.Age >= 40);
            
            if(isOverForty)
            {
                Console.WriteLine($"全部的人都超過40歲");
            }
            else
            {
                Console.WriteLine("有人不到40歲");
            }
            Console.ReadKey();
        }
    }
}

