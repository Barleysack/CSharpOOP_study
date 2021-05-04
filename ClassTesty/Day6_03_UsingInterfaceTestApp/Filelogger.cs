using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_03_UsingInterfaceTestApp
{
    class FileLogger
    {
        private StreamWriter writer;
            public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;

        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"Filelog {DateTime.Now}>>>>>{message}");

        }

    }
}
