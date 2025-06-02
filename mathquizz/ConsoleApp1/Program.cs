using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int record = 0;
            int a = 0;
            int b = 0;

            Random random = new Random();

            Console.WriteLine("Добро пожаловать в математический квиз");
            Console.Write("Напишите уровень сложности от 1 до 3: ");
            int level = int.Parse(Console.ReadLine());

            while (true) 
            {
                a = random.Next(-10 * level, 10 * level);
                b = random.Next(-10 * level, 10 * level);

                Console.Write($"{a} + {b} = ");
                string answer = Console.ReadLine();

                if (a + b == int.Parse(answer)) 
                {
                    score++;
                    Console.WriteLine($"Првильно, ваш счет {score}");
                }
                else
                {
                    Console.WriteLine($"Не правильно, ваш счет {score}");
                }
            }
        }
    }
}
