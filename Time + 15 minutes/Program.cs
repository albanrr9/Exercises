﻿namespace Time___15_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hours + ":0" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
        }
    }
}
