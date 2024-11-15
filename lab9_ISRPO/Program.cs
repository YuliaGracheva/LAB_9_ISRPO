using System;
namespace lab9_ISRPO
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = GetInput("Введите ваше имя: ");
            string age = GetInput("Введите ваш возраст: ");
            PrintGreeting(name, age);
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static void PrintGreeting(string name, string age)
        {
            Console.WriteLine($"Привет, {name}! Вам {age} лет.");
        }
    }
}