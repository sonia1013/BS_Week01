using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample001
{

    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            //list中，所有Age的總和
            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡總和為{total}");
            //list中年齡最小的值
            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"年齡最小為{minAge}");
            //list中年齡最大的值
            var MaxAge = list.Max((x) => x.Age);
            Console.WriteLine($"年齡最大為{MaxAge}");

            //取得list中的數量         
            //請注意Count和Count()是不一樣的
            int count = list.Count();
            Console.WriteLine($"list總個數為{count}");
            int countOfBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"Bill的個數為{countOfBill}");
            //取得所有年齡的平均值
            var average = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為 : {average}");
            Console.ReadLine();



            //找出名稱Bill中的最小Age
            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有Bill中年齡最小的是 : {min}");
            //找出名稱為Bill的年齡總和
            var sum = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有Bill中年齡總和是 : {sum}");

            var ave = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有Bill中年齡平均是 : {ave}");
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill" , Age = 37 },
                new MyData() { Name = "John" , Age = 37 },
                new MyData() { Name = "Tom" , Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bill" , Age = 35 },

            };
        }
    }
}
