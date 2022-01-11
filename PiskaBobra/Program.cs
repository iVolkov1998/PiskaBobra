﻿using System;

namespace PiskaBobra                                         
{                                                            
    class Program                                            
    {
        private static MeetManager meetManager;

        static void Main(string[] args)                      
        {
            meetManager = new MeetManager();

            Console.WriteLine("Введите место встречи: ");
            string user_nameMeet = Console.ReadLine();

            Console.WriteLine("Введите год встречи: ");
            int user_meetTimeYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц встречи: ");
            int user_meetTimeMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день встречи: ");
            int user_meetTimeDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите час встречи: ");
            int user_meetTimeHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минуту встречи: ");
            int user_meetTimeMinute = int.Parse(Console.ReadLine());

            DateTime user_meetTime = new DateTime(
                user_meetTimeYear, 
                user_meetTimeMonth,
                user_meetTimeDay, 
                user_meetTimeHour, 
                user_meetTimeMinute, 
                0
                );

            meetManager.AddNewMeet(user_nameMeet, user_meetTime);

            foreach(var item in meetManager.GetAll())
            {
                Console.WriteLine($"Имя встречи: {item.Name}");
                Console.WriteLine($"Время встречи: {item.MeetTime} /r/n");
            }

            Console.ReadKey();
        }                                                    
    }                                                        
}                                                            
                                                             