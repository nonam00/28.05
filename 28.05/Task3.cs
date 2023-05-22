using System;

namespace _28._05
{
    internal class Task3 : Task
    {
        public override void Do()
        {
            string num = "";
            for(int i = 0; i < 4; i++)
            {
                string str = Console.ReadLine();
                if (str.Length != 1)
                    throw new Exception("Неверный формат записи");
                else
                    num += Console.ReadLine();
            }
            int number = Convert.ToInt32(num);
            Console.WriteLine(number);
        }
    }
}
