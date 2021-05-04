using System;

namespace Day6_01
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO MEOW");
            Cat kitty = new Cat("키티",3);
            /*kitty.Name = "키티";*/
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();
            
            Cat nero = new Cat("NERO","BLACK",10);
            //접근제한자의 이유.

            /*nero.Name = "Nero";*/
            nero.Age = 19;
            nero.Color = "검은";
            nero.Meow();
            Cat mimi = new Cat("미미", "노랑",3);
            mimi.Meow();
            Cat coco = new Cat("코코", "얼룩이");
            coco.Meow();

            Cat noname = new Cat("야옹", 10);
            /*noname.Name = "이야호웅";*/
            noname.Meow();
            //오버라이딩
            //기반 클래스에서 선언된 메소드를 자식 클래스에서 재정의 하는것
            //기반 클래스에서 오버라이딩할 메소드를 미리 virtual로 한정
            //파생 클래스는 virtual 메소드를 override 한정자를 이용해 재선언
            noname.Sleep();
            var list = (First:"가",Second: "나", Third: "다",55);
            Console.WriteLine($"튜플 첫번째: {list.First}");
            Console.WriteLine($"튜플 두번째: {list.Second}");
            Console.WriteLine($"튜플 세번째: {list.Third}");
            Console.WriteLine($"튜플 네번째: {list.Item4}");

        }
    }
}
