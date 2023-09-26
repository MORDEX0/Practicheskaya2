namespace Practicheskaya2
{
    internal class Program
    {
        static void Main()
        {

            Actions();
        }
        static void GuessNum()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine("Попробуй угадай: ");
            while (true)
            {
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

            }
        }
        static void MultiTab()
        {
            int[,] mtab = new int[10, 10];

            for (int row = 1; row < mtab.GetLength(0); row++)
            {
                for (int col = 1; col < mtab.GetLength(1); col++)
                {
                    Console.Write(row * col + "\t");
                }

                Console.WriteLine();
            }
        }
        static void Delitel()
        {
            int dnum = Convert.ToInt32(Console.ReadLine());
            for (int xod = 1; xod * xod <= dnum; xod++)
            {
                if (dnum % xod == 0)
                    Console.Write(xod + "\t");
                
            }
            Console.WriteLine(dnum) ;   
        }

        static void Actions()
        {
            while (true)
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    GuessNum();
                }
                else if (action == 2)
                {
                    MultiTab();
                }
                else if (action == 3)
                {
                    Console.WriteLine("Введите число: ");
                    Delitel();
                }
                else if (action == 4)
                {
                    break;
                }
            }

        }
    }
}