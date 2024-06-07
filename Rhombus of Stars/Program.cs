namespace Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= n - rows; cols++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int cols = 1; cols < rows; cols++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int rows = n - 1; rows >= 1; rows--)
            {
                for (int cols = n - rows; cols >= 1; cols--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int cols = rows; cols > 1; cols--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
