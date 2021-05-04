using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_01
{
    class Cat:Animal
    {
        /*public string Name { get; set; }*/
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { /*nothing*/}
        public Cat( string name, string color, int age)
        {
            //init
            this.Name = name;
            this.Color = color;
            this.Age = age;

        }
        public Cat(string name, int age)
        {
            //init
            this.Name = name;
            
            this.Age = age;
            //this는 객체를 사용하는 코드에서 객체 내부에서 자신을 지칭할때 쓰는 키워드.
        }
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;

        }
        public override void Sleep()
        {
            //base.Sleep();//부모의 SLEEP 메소드 실행.
            //이후 자식 클래스의 SLEEP 내용 실팽
            
            Console.WriteLine($"{this.Color}고양이 {this.Name}이 아주 자아아알 잡니다!");
        }
        public void Meow() { Console.WriteLine("{0},meow!", this.Name);
            Console.WriteLine("{0}{1},meow!", this.Color,this.Name);
        }//this.name이 0으로 들어간다.

        

    }
}
