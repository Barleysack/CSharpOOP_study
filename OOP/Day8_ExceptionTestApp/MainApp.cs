using System;

namespace Day8_ExceptionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램시작!");
            int[] array = new int[5];
            try
            {
                
                
                for (int i = 0; i <= 5; i++)
                {
                    array[i] = i + 1;//

                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"배열 크기에서 벗어난 듯 합니다.{ex.Message}");

            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"예외발생:{ex.Message}");
            }

            finally
            {
                Console.WriteLine("언제든지 실행되는 파이널리");
            }
            
            Console.WriteLine("정상종료");
        }
    }
}
