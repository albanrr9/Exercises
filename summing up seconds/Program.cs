namespace summing_up_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summing up seconds");
            int firstSwimmer = int.Parse(Console.ReadLine());
            int secondSwimmer = int.Parse(Console.ReadLine());
            int thirdSwimmer = int.Parse(Console.ReadLine());
            int seconds = firstSwimmer + secondSwimmer + thirdSwimmer;
            int minutes = 0;
            while (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}
