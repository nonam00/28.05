using System;

namespace _28._05
{
    internal class Task7 : Task
    {
        public override void Do()
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            if(start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for(int i = start; i <= end; i++)
                if(i%2==0)
                    Console.Write(i + " ");
        }
    }
}
