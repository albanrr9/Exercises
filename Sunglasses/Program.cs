namespace Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', (2 * n) - 2));
                Console.Write('*');
                Console.Write(new string('|', n));
                Console.Write('*');
                Console.Write(new string('/', (2 * n) - 2));
                Console.WriteLine('*');
            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
