using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            int results =a1.m(5, 8);
            int sum = a1.m(8, 5);
            Console.WriteLine($" {results} {sum} ");
        }
    }
    public class A
    {
        public int m(int a, int b)
        {
         int add = a + b;
        return add;
       } }}
    

