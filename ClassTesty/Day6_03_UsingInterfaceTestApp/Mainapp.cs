using System;

namespace Day6_03_UsingInterfaceTestApp
{
    class Mainapp
    {
        static void Main(string[] args)
        {
            var monitor = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            //두줄로 써서 보여주실 수 있나요? 이 부분 설명 부탁
            monitor.PrintLog("로그 내용입니다");
            
        }
    }
}
