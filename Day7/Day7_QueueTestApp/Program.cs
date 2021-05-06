using System;
using System.Collections;

namespace Day7_QueueTestApp
{
    class Program
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

        }
    }
}
