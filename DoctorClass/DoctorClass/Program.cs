using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor dr = new Doctor();
            Console.WriteLine($"Doctor name is: {dr.name}");
            Console.WriteLine($"Doctor is {dr.age} yeras old");
            Console.WriteLine($"Doctor has {dr.exp} years of experience");
            Console.WriteLine($"Doctor is a {dr.spl}");
        }
    }
    class Doctor
    {
        public string name = "Dr Suresh";
        public int age = 26;
        public int exp = 4;
        public string spl="Cardiologist";
    }
}

