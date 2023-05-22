using System;

namespace _28._05
{
    internal class Task1 : Task
    {
        private int number;
        public override void Do()
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 100)
                throw new Exception("Введённое число находится вне допустимого диапазона");
            if (Fizz_Buzz())
                Console.WriteLine("Fizz Buzz");
            else if (Buzz())
                Console.WriteLine("Buzz");
            else if (Fizz())
                Console.WriteLine("Fizz");
            else
                Console.WriteLine(number);
        }
        public bool Fizz()
        {
            return (number % 3 == 0);
        }
        public bool Buzz()
        {
            return (number % 5==0);
        }
        public bool Fizz_Buzz()
        {
            return (number % 5 == 0 && number % 3 == 0);
        }
    }
}
