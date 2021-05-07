using System;

namespace Day8_EventHandlerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("369369");

            NotNoti NN = new();
            NN.EVH += new EventHandler(Myhandler);//결국 myhandler한테 맡겨진 일을 수행하게 된다. 



            for (int i = 0; i <= 100; i++)
            {
                NN.Action1(i);//저쪽 '이벤트'가 일어나면... myhandler한테 간다 . 
            }


        }

        private static void Myhandler(string msg)
        {
            Console.Write($"{msg}");
        }
    }
}
