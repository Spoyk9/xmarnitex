using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2._2
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3];
            int diagonalSum = 0;

           
            Console.WriteLine("Введіть значення елементів матриці 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
                        j--; 
                    }
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine($"Сума елементів головної діагоналі: {diagonalSum}");
        }
    }
}
