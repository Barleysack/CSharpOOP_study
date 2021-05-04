using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Day6_02_InterfaceTestAPP
{
    class FileLogger : ILogger//version 1.2이라 쳐보자
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"파일 txt.log에 저장 : {message}");
        }
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러");
        }
    }
}
