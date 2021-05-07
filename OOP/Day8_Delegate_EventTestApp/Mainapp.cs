using System;
 
namespace Day8_Delegate_EventTestApp//Event를 만들기 위해 ...!

{
    class Mainapp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new();//일반호출
            CalcDELE CB;
            CB = new CalcDELE(calc.Plus);
            Console.WriteLine($"3+5 ={ CB(3,5)}");//동적인 처리를 위한...
            //
            CB = new CalcDELE(calc.Mult);
            Console.WriteLine($"4*5={CB(4, 5)}");
        }
    }
}
