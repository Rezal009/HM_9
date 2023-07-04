// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = SumOfNaturalNumbers(M, N);
        Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1}: {2}", M, N, sum);
    }

    static int SumOfNaturalNumbers(int M, int N)
    {
        if (M == N)
        {
            return M;
        }
        else
        {
            return M + SumOfNaturalNumbers(M + 1, N);
        }
    }
}
