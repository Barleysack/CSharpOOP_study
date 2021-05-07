using System;

namespace Day8_GenericTestApp2
{
    class MainApp
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
            CopyArray(src, tgt); }
          
private static void CopyArray<okay>(okay[] src, okay[] tgt)//자료형별로 안만들어도 되니 참 좋구먼요.//꼭 t를 써야하느냐? 저 의미는 무엇이냐?>

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
