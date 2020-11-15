using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<MyData> List = CreateList();
            //開始用var了
            var list = CreateList();


            //這裡的person1是單個物件也就是MyData person1
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於37歲的人第一位被找到的是{person1.Name}");

            //因為找不到就會發生例外
            var person2 = list.First((x) => x.Age < 25);
            Console.WriteLine($"小於25歲的人第一位被找到的是{person2.Name}");

            //Method Expression
            var people = list.Where((x) => x.Name == "Bill");


            Console.ReadLine();
        }


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
         
        //FirstOrDefault 找到符合條件的第一個，沒有的話就回傳預設值
        //First 找到符合條件的第一個，沒有的話就會發生例外
    }
    
}
