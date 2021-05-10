using System;
using System.Reflection;

namespace DynamicCreationTestApp
{
    class Profile
    {
        public string Name { get; set; }
        public string PN { get; set; }
        public void Print() { Console.WriteLine($"{Name},{PN}");

    }
    class Program
    {
        static void Main(string[] args)
        {
                //일반적으로 객체 생성 방식
                Profile pf1 = new Profile();
                pf1.Name = "박찬호";
                pf1.PN = "010-995029-29192";
                pf1.Print();

                //리플렉션-동적 객체 생성 
                Type type = typeof(Profile);
                Object pf2 = Activator.CreateInstance(type);
                PropertyInfo name = type.GetProperty("Name");
                PropertyInfo pn = type.GetProperty("pn");
                name.SetValue(pf2, "류현진", null);
                pn.SetValue(pf2, "010-591292-2959", null);
                MethodInfo print = type.GetMethod("Print");

                print.Invoke(pf2, null);



        }
    }
}
