namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinema");
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            
            int full = rows * cols;
            double income = 0;

            switch (type)
            {
                case "premier":
                    income = full * 12;
                    break;
                case "normal":
                    income = full * 7.5;
                    break;
                case "discount":
                    income = full * 5;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine($"{income:F2}");
        }
    }
}
