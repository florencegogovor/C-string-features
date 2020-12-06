using System;
using System.Dynamic;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input";
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");
            Console.ReadKey();  
        }
    }
}
