namespace Prime_Number_Checking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Checking");

            var n = int.Parse(Console.ReadLine());
            var prime = true;

            if (n >= -2 && n <= 1)
            {
                prime = false;
            }
            else
            {
                for (var i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break; // Exit the loop early since we found a divisor
                    }
                }
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}