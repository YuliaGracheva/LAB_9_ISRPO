using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите ваш возраст: ");
        string age = Console.ReadLine();
        Console.WriteLine($"Привет, {name}! Вам {age} лет.");
    }
}
