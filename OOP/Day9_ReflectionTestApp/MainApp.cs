using System;
using System.Reflection;

namespace Day9_ReflectionTestApp
{   class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void PrintProfile() { Console.WriteLine($"{Age},{Name}"); }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Person a = new();
            Type type = a.GetType();
            FieldInfo[] fields = type.GetFields();
            foreach (var item in fields)
            {
                Console.WriteLine($"Type:{item.FieldType.Name},Name:{item.Name}");

            }
            Console.WriteLine("Method 타입 리스트 :");
            var methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"{item.ReturnType.Name},Name:{item.Name}");
            }
            Console.WriteLine("Property 타입 리스트 : ");
            PropertyInfo[] ppt = type.GetProperties();
            foreach (var item in ppt)
            {
                Console.WriteLine($"Type:{item.PropertyType.Name},Name:{item.Name}");

            }
        }
    }
}
