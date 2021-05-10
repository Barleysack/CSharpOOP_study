using System;

namespace AttributeTestApp
{

    class Myclass
    {
        [Obsolete("이 메서드는 폐기되었습니다")]
        public void OldMethod()
        {
            Console.WriteLine("저거 어떻게 만들지");

        }
        public void NewMethod()
        {
            Console.WriteLine("New thang");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass mc = new();  
            mc.OldMethod();

        }
    }
}
