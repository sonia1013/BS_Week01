using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    class MyData
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();

            //Query Expresstion
            IEnumerable<MyData> people =
              from data in list
              where data.Name == "Bill"
              select data;

            //顯示集合
            foreach (MyData person in people)
            {
                Console.WriteLine($"{person.Name}是{person.Age}歲");
            }
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
    }


}



