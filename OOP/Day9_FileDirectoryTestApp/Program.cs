using System;
using System.IO;
namespace Day9_FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\Desktop\workspace\CSharpOOP_study\test\Help\mui\0412"; //골뱅이를 쓰면 이제 역슬래시에서 도망칠 수 있다.
            //verbatim string - 파이썬에 이런거 없나
            int dirnum = 0;
            var dirs = Directory.GetDirectories(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name}/{dirInfo.Attributes}/{dirInfo.CreationTime}");

            }
            var files = Directory.GetFiles(path);
            foreach(var item in files)
            {
                Console.WriteLine(item);
                var fileinfo = new FileInfo(item);
                Console.WriteLine($"{fileinfo.Name}/{fileinfo.Attributes}/{fileinfo.CreationTime}/{fileinfo.Length}");

            }
            string nupath = @"C:\Users\admin\Desktop\workspace\CSharpOOP_study\test\Help";//디렉토리, 파일생성 위치
            int i = 1;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "X")
                {
                    break;
                }

                else
                {
                    if (input == "file")
                    {
                        Console.WriteLine("파일생성");
                        var filename = $"sample_{DateTime.Now.ToString("yyyyMMddhhmmss")}";
                        var fullpath = @$"{nupath}\{filename}";
                        File.Create(fullpath);
                    }
                    else if (input == "dir")
                    {
                        ;
                        Console.WriteLine("디렉토리 생성");
                        var dirName = "SampleDirectory";
                        var fullpath = @$"{nupath}\{dirName}";
                        if (!Directory.Exists(fullpath))
                        {
                            Directory.CreateDirectory(fullpath);
                        }
                        else
                        {
                            fullpath = @$"{nupath}\{dirName}{dirnum}";
                            Directory.CreateDirectory(fullpath);
                        }
                    }

                    else
                    {
                        //Console.WriteLine("패스처럼 값을 입력하세영");
                    }
                }
            }
        }
    }
}
