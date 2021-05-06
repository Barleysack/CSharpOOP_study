using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_03_UsingInterfaceTestApp
{
    interface ILogger
    {
        void WriteLog(string message);//하나의 메시지를 받아서 처리할 것
    }
}
