using System;

namespace _28._05
{
    internal class Task4 : Task
    {
        public override void Do()
        {
            string number = Console.ReadLine();
            Convert.ToInt32(number);
            if (number.Length != 6)
                throw new Exception("Число должно быть шестизначным");
            int position1 = Convert.ToInt32(Console.ReadLine());
            int position2 = Convert.ToInt32(Console.ReadLine());
            if (position1 < 1 || position2 < 1 || position1 > 6 || position2 > 6)
                throw new Exception("Значение вне диапазона");
            char[] str = number.ToCharArray();
            char temp = str[position1 - 1];
            str[position1-1] = number[position2 - 1];
            str[position2-1] = temp;
            int result = Convert.ToInt32(new string(str));
            Console.WriteLine(result);
        }
    }
}
