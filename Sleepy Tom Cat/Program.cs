namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sleepy Tom Cat!");
            int year = 365;
            Console.Write("Enter number of days which are holidays:");
            int holidays = int.Parse(Console.ReadLine());
            int workDays = year - holidays;
            int totalPlayMinutes = (workDays * 63) + (holidays * 127);
            int difference = Math.Abs(30000 - totalPlayMinutes);
            var hours = difference / 60;
            var minutes = difference % 60;
            if (totalPlayMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
