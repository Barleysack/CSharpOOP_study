using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Delegate_EventTestApp
{

    delegate int CalcDELE(int a, int b);
    class Calc
    {
        public int Plus(int a, int b){return a + b;}
        public int Minus(int a, int b){return a - b;}
        public int Mult(int a, int b){return a * b;}
        public int Div(int a, int b){return a / b;}
        public int Rem(int a, int b){return a % b;}


    }
}
