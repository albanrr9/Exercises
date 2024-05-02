namespace find_the_greater_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the greater number");
            Console.WriteLine("Enter two integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater", num1);
            }
            else
            {
                Console.WriteLine("{0} is greater", num2);
            }
        }
    }
}
