using System;

namespace Day7_AbstractclasstestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();//추상클래스기에 객체화가 불가능, 따라서 자식클래스를 넣는다.//부모는 자식을 품는다.
            obj.PublicMeth();
            obj.AbstractMethod();
           
        }
    }
}
