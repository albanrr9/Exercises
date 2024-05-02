namespace odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd or Even");
            Console.WriteLine("Write a number: ");
            var num = int.Parse(Console.ReadLine());
            var isEven = (num % 2 == 0);
            if (isEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
