namespace House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double basse = (int)Math.Floor(n / 2f);
            double roof = (int)Math.Ceiling(n / 2f);

            var stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }

            for (int i = 0; i < roof; i++)
            {
                var padding = (n - stars) / 2;
                var line = new string('-', padding) + new string('*', stars) + new string('-', padding);
                Console.WriteLine(line);
                stars += 2;
            }

            for (int j = 0; j < basse; j++) 
            {
                var line = '|' + new string('*', n - 2) + '|';
                Console.WriteLine(line);
            }
        }
    }
}
