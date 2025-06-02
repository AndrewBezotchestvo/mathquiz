using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int hp = 3;
            int record = 0;
            int lifes = 3;
            float a = 0;
            float b = 0;

            Random random = new Random();

            Console.WriteLine("Добро пожаловать в математический квиз");
            Console.Write("Напишите уровень сложности от 1 до 10: ");
            int level = int.Parse(Console.ReadLine());

            while (true) 
            {
                a = random.Next(-10 * level, 10 * level);
                b = random.Next(-10 * level, 10 * level);

                if (level > 5)
                {
                    a += (float)random.NextDouble();
                    b += (float)random.NextDouble();
                }

                Console.Write($"{a} + {b} = ");
                string answer = Console.ReadLine();

                if (a + b == float.Parse(answer)) 
                {
                    score++;
                    Console.WriteLine($"Првильно, ваш счет {score}");
                }
                else
                {
                    Console.WriteLine($"Не правильно, ваш счет {score}");
<<<<<<< HEAD
                    lifes--;
                }
                if (lifes <= 0)
                {
                    Console.WriteLine("Игра закончена!");
                    break;
                }


            }
            Console.WriteLine($"Вы проиграли ваш счет:{score}");
=======
                    hp--;
                }
                if (hp == 0)
                {
                    Console.WriteLine("Тебя схавала Математичка");
                    break
                    ;


                }
                
            }
            Console.WriteLine(score);
            Console.WriteLine("THE END");
>>>>>>> 7d8da5458c68b89911216a7a79057009a71c8d7d
        }
    }
}
