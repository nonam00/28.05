﻿using System;

namespace _28._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task;
            Console.WriteLine("Выберете задание");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        task = new Task1();
                        break;
                    case 2:
                        task = new Task2();
                        break;
                    case 3:
                        task = new Task3();
                        break;
                    case 4:
                        task = new Task4();
                        break;
                    case 5:
                        task = new Task5();
                        break;
                    case 6:
                        task = new Task6();
                        break;
                    case 7:
                        task = new Task7();
                        break;
                    default:
                        throw new Exception("Такого задания не существует");
                }
                task.Do();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
