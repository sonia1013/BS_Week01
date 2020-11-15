using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample005
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
            //這裡的person1是單個物件也就是MyData person1
            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            //var num1 = list.FindIndex((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的是{person1.Name}-{person1.Age}");
            
            
            //因為找不到唯一(找到兩個以上或找不到都會發生例外)
            try
            {
                var person2 = list.Single((x) => x.Name =="Bill");
                Console.WriteLine($"找到唯一的是{person2.Name}-{person2.Age}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        

        }
    }
}
