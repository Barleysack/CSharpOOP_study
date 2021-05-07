using System;

namespace Day8_Delegate_ChainApp
{
    delegate int Calcy(int a, int b);
    class Mainapp
    {
        static void Main(string[] args)
        {

            DelegateChainApp delchain = new();
            Firesohot firesohot = new Firesohot(delchain.Call119) + new Firesohot(delchain.ShotOut) + new Firesohot(delchain.Esc);
            
            Calcy CC;
            CC = delegate (int a, int b)
              {
                  return a + b;
              };


            Console.WriteLine($"답은 {CC(3, 4)}");
            
            //대리자 실행,시퀀스 형성의 개념으로 생각해봐도 좋을 것 같다. 

            firesohot("화재장소");
            
            //익명 메서드//일회용 메서드. 다른 코드 블록에서 재사용될 일 이 없는 이름없는 메소드.

            
               
            
        }
    }
}
