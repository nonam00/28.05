using System;

namespace _28._05
{
    internal class Task2 : Task
    {
        public override void Do()
        {
            Console.WriteLine("Введите число и процент от него");
            int number = Convert.ToInt32(Console.ReadLine());
            double percent= Convert.ToDouble(Console.ReadLine())/100;
            //Может существовать отрицательный процент, поэтому исключение не требуется
            Console.WriteLine(number * percent);
        }
    }
}
