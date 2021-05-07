using System;
using System.Collections.Generic;
namespace Day8_GenereicCollection
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트 =============");



            List<int> list = new();
            for (int i = 0; i <= 100; i++)
            {
                list.Add(i);
            }


            var sumn = 0;
            foreach (var item in list)
            {
                sumn = item + sumn;

            }
            Console.WriteLine($"결과는 {sumn}");
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Queue<string> home = new();
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");
            home.Enqueue("d");


            Dictionary<string, int> dics = new();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            
        }    }
}
