﻿using System;

namespace GenericMyListApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<int> list = new();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;

            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }
            MyList<string> slist = new();

            for (int i = 0; i < slist.Length; i++)
            {
                slist[i] ="Hi";

            }
            for (int i = 0; i < slist.Length; i++)
            {
                Console.Write($"{slist[i]}\t");
            }
        }
    }
}
