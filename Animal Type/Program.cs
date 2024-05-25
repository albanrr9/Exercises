namespace Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Type");
            string animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
