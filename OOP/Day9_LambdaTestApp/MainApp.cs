using System;

namespace Day9_LambdaTestApp
{


    class MainApp
    {   //Func 내부 파리미터는- 리턴값을 늘 가장 마지막에 잡는다. 
        delegate void Dosth(string name);
        //void는 리턴이 있지만 리턴할 값이 존재치 않는 것이다. 
        //func 대리자: 반환값이 있는 익명메소드.
        //action 대리자 : 반환값 없는 메소드. 
        delegate string CCN(string[] a1);
        static void Main(string[] args)
        {
            Dosth dodo = (name) =>
            {
                Console.WriteLine("HI-HI");
                Console.WriteLine(name);
            };//요거슨 익명함수.
            string name = "bobo";
            CCN cc = (a1) =>
            {
                string result = "";
                foreach(var item in a1)
                {
                    result = result + item;

                }
                return result;
            };
            string[] a2 = { "김", "보", "성" };
            Console.WriteLine(cc(a2));
            dodo(name);
            Func<int> fc1 = () => 3;
            var val = fc1();
            Console.WriteLine(val);
            Func<int, int, int> add= (x, y) => x + y;//마지막은 리턴값.;
            Console.WriteLine(add(3, 5));
            //한번 쓰고 버릴 익명함수를 만들때는 이렇게 사용합니다...
            //Action.void 처럼 사용한다. 
            Action<int> area = (r) =>
             {
                 Console.WriteLine($"원의 넓이는 {r * r * Math.PI}");
             };

            area(10);
        }
    }
   
}
