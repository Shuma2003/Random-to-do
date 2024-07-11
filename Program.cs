using System;

namespace Random_to_do
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int RandomNumber = random.Next(1, 6);


            switch (RandomNumber)
            {
                case 1:
                    Console.WriteLine("1. Решение задач на codewars или leetcode");
                    break;
                case 2:
                    Console.WriteLine("2. Создание игры");
                    break;
                case 3:
                    Console.WriteLine("3. Посмотреть ютуб");
                    break;
                case 4:
                    Console.WriteLine("4. Выйти на улицу");
                        break;
                case 5:
                    Console.WriteLine("Пиши код!Практикуйся");
                    break;

                            


            }
        }
    }
}
