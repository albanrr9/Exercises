namespace Summing_up_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= integers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
