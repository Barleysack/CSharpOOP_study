using System;
using System.Collections.Generic;

namespace Day10_Test
{
    
    class MainAPP
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> rainbow = new();
            rainbow["red"] = "빨간색";
            rainbow["orange"] = "주황색";
            rainbow["yellow"] = "노란색";
            rainbow["green"] = "초록색";
            rainbow["blue"] = "파란색";
            rainbow["indigo"] = "남색";
            rainbow["purple"] = "보라색";
            

            Console.Write($"무지개 색은");
            foreach (var item in rainbow)
            {
                Console.Write($" {item.Value},");
            }
            Console.Write(" 입니다.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Key와 Value 확인");
            Console.WriteLine($"Purple은 {rainbow["purple"]} 입니다.");





        }
    }

  
}
