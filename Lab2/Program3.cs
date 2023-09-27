using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2._3
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 11);
            int attempts = 0;
            bool guessed = false;

            Console.WriteLine("Гра \"Вгадай число\" (від 0 до 10 включно)");

            while (!guessed)
            {
                int guess;

                while (true)
                {
                    Console.Write("Введіть свій варіант: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out guess) && guess >= 0 && guess <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некоректне введення. Введіть ціле число від 0 до 10.");
                    }
                }

                attempts++;

                if (guess == secretNumber)
                {
                    guessed = true;
                    Console.WriteLine($"Ви вгадали число {secretNumber} за {attempts} спроб.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загадане число більше.");
                }
                else
                {
                    Console.WriteLine("Загадане число менше.");
                }
            }
        }
    }
}
