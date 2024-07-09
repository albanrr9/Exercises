namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            var middle = -1;


            if (n % 2 == 0)
            {
                stars = 2;
                middle = 0;
            }

            var padding = (n - stars) / 2;

            if (n <= 2)
            {
                Console.WriteLine(new string('*', n));
            }

            else
            {

                for (int i = 0; i < Math.Ceiling(n / 2f); i++)
                {
                    if (i == 0)
                    {
                        string line = new string('-', padding) + new string('*', stars) + new string('-', padding);
                        Console.WriteLine(line);
                    }
                    if (i > 0)
                    {
                        string line = new string('-', padding) + '*' + new string('-', middle) + '*' + new string('-', padding);
                        Console.WriteLine(line);
                    }
                    middle += 2;
                    padding--;
                }
                padding = 1;
                middle = n - 4;
                for (int i = (int)Math.Floor(n / 2f); i > 0; i--)
                {
                    if (i > 1)
                    {
                        string line = new string('-', padding) + '*' + new string('-', middle) + '*' + new string('-', padding);
                        Console.WriteLine(line);
                    }
                    if (i == 1)
                    {
                        string line = new string('-', padding) + new string('*', stars) + new string('-', padding);
                        Console.WriteLine(line);
                    }
                    middle -= 2;
                    padding++;
                }
            }
        }
    }
}
