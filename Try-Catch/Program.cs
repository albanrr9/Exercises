namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter even number: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                Console.WriteLine("The number is not even");
            }
        }
    }
}