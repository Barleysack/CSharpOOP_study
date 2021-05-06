using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_AbstractclasstestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            //버추얼때 썼던것..재정의하기위해 사용합니다. //이유는 궁금해하지 맙시다...
            Console.WriteLine("Derived.AbstractMethod() 실행!");
            base.ProtectedMethodA();
            this.PublicMeth();
            

        }
    }
}
