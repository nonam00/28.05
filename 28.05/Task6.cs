using System;

namespace _28._05
{
    internal class Task6 : Task
    {
        public override void Do()
        {
            Console.WriteLine("Выберете режим перевода: ");
            Console.WriteLine("1 - из °C в °F\n2 - из °F в °C");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите показатель тепературы в °C");
                    double tempeture1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(((tempeture1 * 9.5) + 32) + "°F");
                    break;
                case 2:
                    Console.WriteLine("Введите показатель тепературы в °F");
                    double tempeture2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(((tempeture2 - 32) * 5 / 9) + "°C");
                    break;
                default:
                    throw new Exception("Ошибка выбора");
            }

        }
    }
}
