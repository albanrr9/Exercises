namespace Methods_with_parameters
{
    internal class Program
    {
        static void PrintLine(int start = 0, int end = 0)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}