namespace Division_without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double div2 = 0;
            double div3 = 0;
            double div4 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    div2++;
                }
                if (num % 3 == 0)
                {
                    div3++;
                }
                if (num % 4 == 0)
                {
                    div4++;
                }
            }

            double d2 = div2 / n * 100.00;
            double d3 = div3 / n * 100.00;
            double d4 = div4 / n * 100.00;

            Console.WriteLine($"{d2:F2}%\n{d3:F2}%\n{d4:F2}%");
        }
    }
}