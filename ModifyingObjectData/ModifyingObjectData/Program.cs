using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            doctor dl = new doctor();
            Console.WriteLine(dl.name);
            Console.WriteLine(dl.age);
            Console.WriteLine(dl.exp);
            Console.WriteLine(dl.spl);
            dl.name = "Dr.Suresh";
            dl.age = 30;
            dl.exp = 8;
            dl.spl = "Neurology";
            Console.WriteLine(dl.name);
            Console.WriteLine(dl.age);
            Console.WriteLine(dl.exp);
            Console.WriteLine(dl.spl);
            Console.ReadLine();

        }
    }
    public class doctor
    {
        public string name = "Dr Abhishek";
        public int age = 22;
        public int exp = 2;
        public string spl = "Cardiology";
    }
}

