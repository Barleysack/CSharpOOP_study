using System;

namespace ArrayTestApp
{
    class MainApp
    {
        static void Main(string[] args)




        {


            Console.WriteLine("array 클래스 사용");
            int[] array = new int[]{ 5, 2, 1, 5, 6, 7, 8, 9, 2 };

            System.Array.Sort(array);
            Array.Resize<int>(ref array, 11);
            
            Console.WriteLine($"");
            
            /*Console.WriteLine($"수학학원 점수");
            int[] scores = { 3, 4, 5, 6, 7, 8, 9, 10 };//최종 제일 짧은 초기화 방법 
            *//*scores[0] = 80;
            scores[1] = 77;
            scores[2] = 56;
            scores[3] = 78;
            scores[4] = 56;*//*
            */
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];

            }
            float average = (float)sum / array.Length;
            Console.WriteLine($"수학학원 점수 총합 :{sum}, 평균: {average}");
        }   
    }
}

