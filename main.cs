using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            Console.WriteLine("Год является високосным.");
        }
        else
        {
            Console.WriteLine("Год не является високосным.");
        }
    }
}
