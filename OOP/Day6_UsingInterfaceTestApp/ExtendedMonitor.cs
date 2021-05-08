using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_03_UsingInterfaceTestApp
{
    class ExtendedMonitor //ver 1.0
    {

        private ILogger logger;
        private FileLogger fileLogger;

        public ExtendedMonitor(ILogger logger)
        {
            this.logger = logger;


        }

        public ExtendedMonitor(FileLogger fileLogger)
        {
            this.fileLogger = fileLogger;
        }

        public void PrintLog(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
