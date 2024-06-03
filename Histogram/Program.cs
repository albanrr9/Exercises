namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int input;
            int pc1 = 0;
            int pc2 = 0;
            int pc3 = 0;
            int pc4 = 0;
            int pc5 = 0;

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 199)
                {
                    pc1++;
                }
                if (input >= 200 && input <= 399)
                {
                    pc2++;
                }
                if (input >= 400 && input <= 599)
                {
                    pc3++;
                }
                if (input >= 600 && input <= 799)
                {
                    pc4++;
                }
                if (input >= 800)
                {
                    pc5++;
                }
            }

            double p1 = pc1 * 100.00 / n;
            double p2 = pc2 * 100.00 / n;
            double p3 = pc3 * 100.00 / n;
            double p4 = pc4 * 100.00 / n;
            double p5 = pc5 * 100.00 / n;

            string output = string.Format($"{p1:F2}%\n{p2:F2}%\n{p3:F2}%\n{p4:F2}%\n{p5:F2}%");

            Console.WriteLine(output);
        }
    }
}
