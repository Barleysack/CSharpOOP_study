using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_02_InterfaceTestAPP
{
    // 약속이다. 이 ILogger를 구현하게 되면 아래의 액션을 무조건 구현해야한다.(구현=상속)
    interface ILogger
    {
        void WriteLog(string message);//하나의 메시지를 받아서 처리할 것
        void WriteError(string error);
    }
}
