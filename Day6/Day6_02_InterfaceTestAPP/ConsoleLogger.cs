using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Day6_02_InterfaceTestAPP
{
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
            //예외는 THROW!
            
        }
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러");
        }
    }
}
