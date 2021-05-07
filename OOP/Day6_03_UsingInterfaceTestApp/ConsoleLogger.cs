using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_03_UsingInterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public DateTime Currenttime { get; set; }
        
        public DateTime solly { get; set; }
    
    
        
        public ConsoleLogger(DateTime currenttime)
        {
            this.Currenttime = currenttime;
            this.solly = currenttime;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"Console Log:{solly} {message}");
        }
    
    }
}
