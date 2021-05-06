using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_AbstractclasstestApp
{
    abstract class AbstractBase
    {
       protected void ProtectedMethodA()
        {
            Console.WriteLine("AbstractBase.ProtectedMethod() 실행");

        }

       public void PublicMeth()
        {
            Console.WriteLine("AbstractBase.PublicdMethod() 실행");
        }

        public abstract void AbstractMethod();//인터페이스 선언과 동일 상속받으면 구현해야함.

    }
}
