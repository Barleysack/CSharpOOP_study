using System;

namespace Day10_Test
{
    
    class MainAPP
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }

    class Boiler
    {

        public string Brand { get; set; }
        public byte _Voltage { get; set; }
        public byte Voltage
        {

            get => this._Voltage;
            set
            {
                if (value == 110)
                {
                    _Voltage = value;

                }
                else if (value == 220)
                {
                    _Voltage = value;

                }
                else
                {

                    Console.WriteLine("규격에 맞지 않는 전압입니다");

                }
            }
        }
        public int Tempfriend { get; set; }
        public int Temperature
        {
            get => Tempfriend;
            set
            {
                if (value <= 5)
                {

                    Tempfriend = 5;

                }
                else if (value >= 70)
                {

                    Tempfriend = 70;

                }
                else
                {

                    Tempfriend = value;


                }
            }
        }
        public void PrintAll()
        {
            Console.WriteLine($" Brand = {Brand}, Voltage = {Voltage}, Temperature = {Temperature}");
        }
    }
}
