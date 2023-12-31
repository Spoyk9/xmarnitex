﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];

            // Введення чисел користувачем
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введіть {i + 1}-е число: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    // Перевірка, чи число додатнє
                    if (numbers[i] <= 0)
                    {
                        Console.WriteLine("Будь ласка, введіть додатнє число.");
                        i--; // Повторення введення числа
                    }
                }
                else
                {
                    Console.WriteLine("Некоректне введення. Будь ласка, введіть число.");
                    i--; // Повторення введення числа
                }
            }

            int minPositive = int.MaxValue;

            // Пошук найменшого додатнього числа
            foreach (int number in numbers)
            {
                if (number > 0 && number < minPositive)
                {
                    minPositive = number;
                }
            }

            if (minPositive == int.MaxValue)
            {
                Console.WriteLine("В списку немає додатніх чисел.");
            }
            else
            {
                Console.WriteLine($"Найменше додатнє число в списку: {minPositive}");
                Console.WriteLine();
            }
        }
    }
}
