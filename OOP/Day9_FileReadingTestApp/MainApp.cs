using System;
using System.IO;

namespace Day9_FileReadingTestApp
{
    class Mainapp
    {
        static void Main(string[] args)
        {
            /*string fullpath = @"c:\windows\PFRO.log";
            StreamReader sr = new StreamReader((new FileStream(fullpath, FileMode.Open)));

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();*/
            string WritePath = @"C:\kbs.txt";
            StreamWriter sw = new(new FileStream(WritePath, FileMode.Create));

            sw.Write("Hello,World");
            sw.Close();//필수

            Console.WriteLine("텍스트 파일 작성완료");
        }
    }
}
