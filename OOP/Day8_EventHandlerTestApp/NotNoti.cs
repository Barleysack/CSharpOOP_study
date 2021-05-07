using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_EventHandlerTestApp
{
    delegate void EventHandler(string msg);
    //대리자 선언.
    class NotNoti
    {
        public event EventHandler EVH;
        

        public void Action1(int number)
        {
            
            if (number%3==0)
            {
                EVH($"{number} : 짝");
                //저 대리자가 하는 일이다. 
            }
            else
            {
                EVH($"{number}");
            }
        }
    }
}
