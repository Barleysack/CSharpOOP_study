using System;

namespace Day6_02_InterfaceTestAPP
{
    
    
    
    
    
    class Mainapp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USING CONSOLELOGGER");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다");
            ILogger loggyfoggy = new FileLogger();//버전 수정등에 유용하다.ver 1.0 climate logger에서 1.2로 바로 변경 가능.
            loggyfoggy.WriteLog("맑음");
           // logger.WriteError("ERROR");
            //loggyfoggy.WriteError("error");
            ILogger logged = new ClimateLogger();
            logged.WriteLog("흐림");
            //logged.WriteError("!!!!");

        }
    }
}
