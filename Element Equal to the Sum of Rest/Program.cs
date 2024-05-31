namespace Element_Equal_to_the_Sum_of_Rest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -10000000;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes, sum = " + sum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum - max));
            }
        }
    }
}
