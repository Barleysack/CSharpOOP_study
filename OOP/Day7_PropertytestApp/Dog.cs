using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_PropertytestApp
{
    class Dog
    {
        private int age;
        public string Name { get; set; } = "멍멍이"; //제약조건도 딱히 필요 없네..?//get.set의 진정한 의미는 프로퍼티로서 선언한다는 말.
        //프로퍼티로서 선언하기에 이를 제한할 방법이 생긴다.
        // 아니었다면 끌어다 쓰는 곳에서 꾸준히 제한을 걸게 된다.

        
        public int Age
        {
            get => this.age;

            set => this.age = value;
            

            
        }
/*
        public int GetAge() 
        {
            return this.age;//값을 사용
        }
        public void SetAge(int age)
        {
            this.age = age;//값을 설정
        }
*/

    }
}
