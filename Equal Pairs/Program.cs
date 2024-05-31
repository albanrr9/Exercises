namespace Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] pairs = new int[n];
            int maxDiff = 0;
            int j = 1;

            for (int i = 0; i < pairs.Length; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                pairs[i] = num1 + num2;
            }
            for (int i = 0; i < pairs.Length - 1; i++)
            {
                int diff = Math.Abs(pairs[i] - pairs[j]);
                j++;
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            if (maxDiff != 0)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", pairs[0]);
            }
        }
    }
}
