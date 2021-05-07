using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Day6_02_InterfaceTestAPP
{
    class ClimateLogger : ILogger//version 1.0이라 치자
    {
        public void WriteLog(string weather)
        {
            Console.WriteLine($"날씨 로그 :[ {DateTime.Now.ToShortDateString()}] 현재 날씨: {weather}");
        }
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러");
        }
    }
}
