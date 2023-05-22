using System;

namespace _28._05
{
    internal class Task5 : Task
    {
        private DateTime time;
        public override void Do()
        {
            time = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"{Season()} {time.DayOfWeek}");
        }
        public string Season()
        {
            int month = Convert.ToInt32(time.Month);
            if (month == 12 || month <= 2)
                return "Winter";
            else if (month >= 3 && month <= 5)
                return "Spring";
            else if (month >= 6 && month <= 8)
                return "Summer";
            else if (month >= 9 && month <= 11)
                return "Fall";
            else
                throw new Exception("Error");
        }
    }
}
