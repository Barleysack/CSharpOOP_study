﻿using System;

namespace Day7_IndexerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");
            MyList list = new MyList();
            for (int i = 0; i <list.Length; i++)
            {
                list[i] = i + 1;//1~5
            }
            for (int i = 0; i < list.Length ; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
