﻿namespace Back_to_the_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int age = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    heritage -= 12000;
                }
                else
                {
                    heritage -= (12000 + (50 * age));
                }
                age++;
            }

            if (heritage > 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:F2} dollars left");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):F2} dollars to survive.");
            }
        }
    }
}
