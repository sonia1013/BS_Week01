using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample007
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            //要to一定要最後to，因為在LINQ to是最後才會迭代的
            //跟記憶體與效能有關，後放後處理比較不占記憶體空間 Dictionary<key,value>
            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();
            // 使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData
            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);

            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"{item.Value.Name}---{item.Value.Age}");
            }

            Console.WriteLine("--------------");
            //// 使用 Name 當群組分類的索引鍵，而且用 Age 當值資料
            //可是key不能一對多，否則會報錯
            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill" , Age = 37 },
                new MyData() { Name = "John" , Age = 37 },
                new MyData() { Name = "Tom" , Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bokoblin" , Age = 105 },

            };
        }
    }
}
