using System;
using System.Collections;

namespace Day7_QueueTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Queuetest");

            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
            {
                var q = queue.Dequeue();
                Console.WriteLine(q+"\t");
            }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                var a = stack.Pop();
                Console.WriteLine(a);
            }


            Hashtable dict = new Hashtable();
            dict["book"] = "책";
            dict["cook"] = "요리사";
            dict["hook"] = "갈고리";
            
            Console.WriteLine(dict["cook"]);



            
        }

            


    
    
    }


}
