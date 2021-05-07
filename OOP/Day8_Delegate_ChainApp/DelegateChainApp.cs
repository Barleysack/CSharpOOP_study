using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Delegate_ChainApp
{
    delegate void Firesohot(string location);
    
    class DelegateChainApp
    {
        public void Call119(string location) { Console.WriteLine($"소방서 ㅎㅇ,주소는 {location}"); }
        public void ShotOut(string location) { Console.WriteLine($"피해!{location} 불이야!"); }
        public void Esc(string location) { Console.WriteLine($"{location}에서 도망쳐!"); }

    }
}
