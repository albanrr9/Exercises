namespace Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write('+');
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int rows = 0; rows < n - 2; rows++)
            {
                Console.Write('|');
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write('+');
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
