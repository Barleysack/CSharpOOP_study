using System;
using System.Collections.Generic;
using System.Linq;
namespace Day9_LinqTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {

            List<int> d = new() { 2, 3, 4, 1, 2, 3, 1, 254, 2 };
            d.Sort();

            

            List<Profile> profiles = new();
            profiles.Add(new Profile() { Name = "정주성", Height = 178 });
            profiles.Add(new Profile() { Name = "정가성", Height = 128 });
            profiles.Add(new Profile() { Name = "정후성", Height = 158 });
            profiles.Add(new Profile() { Name = "정호성", Height = 168 });
            profiles.Add(new Profile() { Name = "정예성", Height = 188 });

            /*List<Profile> profiles2 = new();

            foreach (var item in profiles)
            {
                if (item.Height < 170)
                    profiles2.Add(item);


            }*/

            var pf2 = from item in profiles
                      where item.Height < 170
                      orderby item.Height descending//ascending이 기본. 디폴트. 
                      select new { Name = item.Name, Inch = item.Height * 0.393 };

            foreach (var item in pf2)
            {
                Console.WriteLine($"{item.Name}: {item.Inch}");

            }
            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }
            var result = from item in numbers
                         where item % 3 == 0
                         select item;
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

            //15.3
            Console.WriteLine("");
            InstClass[] arrClass =
            {
                new InstClass(){Name="연두반",Scores = new int[]{99,80,64,99} },
                new InstClass(){Name="호두반",Scores = new int[]{93,81,63,99} },
                new InstClass(){Name="마두반",Scores = new int[]{89,83,62,99} },
                new InstClass(){Name="고두반",Scores = new int[]{99,85,61,99} },

            };
            
            var classes = from item in arrClass
                          from score in item.Scores
                          where score < 70
                          orderby score
                          select new { item.Name, Lowest = score };

            foreach (var item in classes)
            {
                Console.WriteLine($"{item.Name}:{item.Lowest}");

            }
            //groupby
            var listProfile = from item in profiles
                              orderby item.Height
                              group item by item.Height < 172 into g
                              select new { GroupKey = g.Key, profiles = g };
            foreach (var item in listProfile)
            {
                Console.WriteLine($"-172미만 :{item.GroupKey}");
                foreach (var subitem in item.profiles)
                {
                    Console.WriteLine($">>>{subitem.Name}:{subitem.Height}");
                }


            }

            var pf3 = profiles.Where(p => p.Height < 172)
                            .OrderByDescending(p => p.Height)
                            .Select(item => new
                            {
                                Name = item.Name,
                                Inch = item.Height * 0.393
                            });


        }
    }
}
