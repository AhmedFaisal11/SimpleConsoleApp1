using System;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Your Name : ");
            var name = Console.Read();
            var currentDate = DateTime.Now;

            Console.WriteLine($"Hello , {name}  on {currentDate:d} at {currentDate:t} ");
            Console.WriteLine($"Press any Key to Exit....");
            Console.ReadKey(true);
        }
    }
}
