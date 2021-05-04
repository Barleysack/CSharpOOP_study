using System;

namespace Day6_03_UsingInterfaceTestApp
{
    class Mainapp
    {
        static void Main(string[] args)
        {
            var monitor = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor.PrintLog("로그 내용입니다");
            
        }
    }
}
