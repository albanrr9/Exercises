﻿namespace Square_Made_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write('*');
                for (int j = 1; j < n; j++) {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
