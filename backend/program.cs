using System;

namespace BackendAppddd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!");

            Console.WriteLine(DayOfWeek);
        }
    }
}