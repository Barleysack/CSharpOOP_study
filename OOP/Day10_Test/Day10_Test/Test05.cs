using System;
using System.Collections.Generic;

namespace Day10_Test
{
    
    class MainAPP
    {
        static void Main(string[] args)
        {
            강아지 왈왈이 = new 강아지();
            왈왈이.Age = 5;
            왈왈이.Name = "뽀삐";
            왈왈이.Eat();
            왈왈이.Sleep();
            왈왈이.Sound();




        }
    }

    interface IAnimal
    {
        int Age { get; set; }
        string Name { get; set; }
        void Eat();
        void Sleep();
        void Sound();
    }

    class 강아지 : IAnimal
    {
        public int Age { get; set; }
        public string Name{ get; set; }
        public void Eat()
        {
            Console.WriteLine("우적우적");
        }

        public void Sleep()
        {
            Console.WriteLine("드르렁 푸우");
        }

        public void Sound()
        {
            Console.WriteLine("왈!왈!왈!왈!");
        }
    }

    class 고양이 : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine("우적우적");
        }

        public void Sleep()
        {
            Console.WriteLine("드르렁 푸우");
        }

        public void Sound()
        {
            Console.WriteLine("이야아아옹");
        }
    }

    class 말 : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine("우적우적");
        }

        public void Sleep()
        {
            Console.WriteLine("드르렁 푸우");
        }

        public void Sound()
        {
            Console.WriteLine("히히히힝!");
        }
    }


}
