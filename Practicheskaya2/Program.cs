using System;
using System.Data;
using static System.Collections.Specialized.BitVector32;

namespace Practicheskaya2
{
    internal class Program
    {
        public static void Main()
        {
            char action = 'A';
            while (action != ((char)ConsoleKey.D4)) 
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                action = Console.ReadKey(true).KeyChar;
                switch (action)
                {
                    case '1':
                        GuessNum();

                        break;
                    case '2':
                        MultiTab();

                        break;
                    case '3':
                        Delitel();

                        break;
                }
               
            
            } 

        }
        static void GuessNum()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine("Попробуй угадай(есть 8 попыток): ");
            int i = 0;
            while (i <= 8)
            {
                i++;
                int gnumber = Convert.ToInt32(Console.ReadLine());
                if (gnumber < number)
                {
                    Console.WriteLine("Бери больше");
                }
                else if (gnumber > number)
                {
                    Console.WriteLine("Бери меньше");
                }
                else if (gnumber == number)
                {
                    Console.WriteLine("Молодец!!!");
                    break;
                }
                else if (i == 9)
                {
                    Console.WriteLine("YOU LOSER");
                }
            }
            

        }

        static void MultiTab()
        {
            int[,] mtab = new int[10, 10];

            for (int row = 1; row < mtab.GetLength(0); row++)
            {
                for (int col = 1; col < mtab.GetLength(1); col++)
                {
                    mtab[row, col] = row * col;
                    Console.Write(mtab[row, col] + "\t");
                }
                Console.WriteLine( );
            }
            
        }
        
        static void Delitel()
        {
            Console.WriteLine("Введите число: ");
            int dnum = Convert.ToInt32(Console.ReadLine());
            int xod = 0;
            while (xod <= dnum) 
            {
                xod++;
                if (dnum % xod == 0)
                    Console.Write(xod + "\t");
            }   
            Console.WriteLine();
        }

        }
    }


