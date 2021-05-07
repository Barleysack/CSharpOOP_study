using System;

namespace Day8_GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] src = { 1, 2, 3, 4, 5 };
            int[] tgt = new int[src.Length];
            foreach (var item in tgt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("복사중입니다");
            CopyArray(src,tgt);
            //static 안에서 메소드를 만들어버리면 죄다 스태틱이 되어버린다. 그래서 그렇게 쪼개대었구나...
           
            
        }
    
        private static void CopyArray(int[] src, int[] tgt)
        {
            Console.WriteLine("");
            for (int i = 0; i < src.Length; i++)
            {
                tgt[i] = src[i];

            }

            foreach (var item in tgt)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
