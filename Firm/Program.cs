namespace Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firm");
            Console.Write("Needed hours:");
            int neededHours = int.Parse(Console.ReadLine());
            Console.Write("Available days:");
            int availableDays = int.Parse(Console.ReadLine());
            Console.Write("Number of workers:");
            int workers = int.Parse(Console.ReadLine());

            var daysLeft = availableDays * 0.9;
            var hours = daysLeft * workers * 10;

            if(hours > neededHours)
            {
                hours = Math.Abs(hours - neededHours);
                Console.WriteLine("Yes! {0} hours left.", hours);
            }
            else
            {
                hours = Math.Abs(hours - neededHours);
                Console.WriteLine("Not enough time! {0} hours needed.", hours);
            }


        }
    }
}
