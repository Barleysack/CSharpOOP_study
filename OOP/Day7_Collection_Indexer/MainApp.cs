using System;
using System.Collections;

namespace Day7_Collection_Indexer
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object ob = (object)a;
            string str = "문자";
            
            ArrayList me = new ArrayList();//사이즈 지정 x
            me.Add(3);
            me.Add(4);
            me.Add(5);
            me.Add(6);
            me.Add(7);
            me.Add(8);
            me.Add(9);
            me.Add(20);
            me.Add(2);
            me.Add(1);
            me.Add(11);
            /*me.LastIndexOf*/
            me.Insert(2, 192);
            me.RemoveAt(5);
            
            var added = me.IndexOf(192);
            Console.WriteLine($"{added}");


            foreach (var item in me)
            {
                Console.WriteLine(item);//object 타입이 들어가고 있다. 객체지향적..
                //object는 모든 클래스의 조상 [객체,object]
            }
        }
    }
}
