﻿namespace Sum_of_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    sum++;
                }
                if (input[i] == 'e')
                {
                    sum += 2;
                }
                if (input[i] == 'i')
                {
                    sum += 3;
                }
                if (input[i] == 'o')
                {
                    sum += 4;
                }
                if (input[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}
