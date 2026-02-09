using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            Patient pl = new Patient();
            Console.WriteLine($"Patient Name is :{pl.name}");
            Console.WriteLine($"Patient Age is :{pl.age}");
            Console.WriteLine($"Patient Gender is:{pl.gender}");
            Console.WriteLine($"Patient blood Group is :{pl.BG}");
            Console.WriteLine($"Patient LOcation is :{pl.loc}");
            Console.WriteLine($"Patient Disease is :{pl.disease}");
        } 
    }
         public class Patient
        {
            public string name = "John The Don";
            public int age = 25;
            public string gender = "Male";
            public string BG = "O +ve";
            public string loc="Bengaluru";
            public string disease="Dengue";
        }
}
