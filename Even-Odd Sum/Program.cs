namespace Even_Odd_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 1;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (odd == 0)
                {
                    sum1 = sum1 + int.Parse(Console.ReadLine());
                    odd = 1;
                    continue;
                }
                if (odd == 1)
                {
                    sum2 = sum2 + int.Parse(Console.ReadLine());
                    odd = 0;
                    continue;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            if (sum1 != sum2)
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum2 - sum1));
            }
        }
    }
}
