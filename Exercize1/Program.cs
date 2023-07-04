// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;

class Program
{
    static void Main()
    {
        int N = 10;
        PrintNumbers(N);
    }

    static void PrintNumbers(int N)
    {
        if (N <= 0)
            return;

        Console.Write(N);
        if (N > 1)
            Console.Write(", ");

        PrintNumbers(N - 1);
    }
}
