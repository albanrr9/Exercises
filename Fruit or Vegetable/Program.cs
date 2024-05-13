using System;

namespace Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes") Console.WriteLine("Fruit");
            else if (s == "tomato" || s == "cucmber" || s == "pepper" || s == "carrot") Console.WriteLine("Vegetable");
            else Console.WriteLine("unknown");
        }
    }
}