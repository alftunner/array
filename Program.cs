using System;
using static System.Console;

namespace massive
{
    class Program
    {
        public static int Total(int[,] array) // Сумма элементов массива
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    total += array[i,j];
                }
            }
            return total;
        }
        public static double Average(int[,] array) // Среднее значение
        {
            double average = Total(array) / 25;
            return average;
        }
        public static int Min(int[,] array) // Поиск минимального значения
        {
            int min = array[0,0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(min < array[i,j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public static int Max(int[,] array) // Поиск максимального значения
        {
            int max = array[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (max > array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                    Write($"{array[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine($"Сумма всех элементов: {Total(array)}");
            WriteLine($"Среднее значение: {Average(array)}");
            WriteLine($"Минимальное значение: {Min(array)}");
            WriteLine($"Максимальное значение: {Max(array)}");
        }
    }
}
