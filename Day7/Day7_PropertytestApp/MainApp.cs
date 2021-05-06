using System;

namespace Day7_PropertytestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gang-Arch");
            Dog bk = new Dog();
            //초창기.
            /*bk.SetAge(5);
            Console.WriteLine($"백구의 나이는 {bk.GetAge()}");-초창기*/
            bk.Age = 25000;
            Console.WriteLine($"BK.AGE={bk.Age}");//-중반기
            Dog dog2 = new ()
            { Name = "blaky",Age=5};
            var Instanty = new { Name = "hoho", Age = 29 };//무명형식. 어나니머스. var과 함께 쓰며, 지역에서만 쓰고 버리는 것이다. 
            Console.WriteLine(Instanty.Name);
            Console.WriteLine(Instanty.Age);
            //프로퍼티란. 객체를 만들기 위한 특성들이다. 
            //그냥 접근하면 잘못된 값이 들어갈 수 있다.
            //제약을 만들기 위해 프로퍼티 를 사용한다.
            //참조는 힙/ 값은 스택.
            Random rnd = new();
            int[] hi = new int[11];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    hi[j] = rnd.Next(1, 10);

                }
                Console.WriteLine(hi[i]);
            } 

            
        }
    }
}
