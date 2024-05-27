using System;

class Program
{
    static void Main(string[] args)
    {
        // Read input data
        string year = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        int sofiaWeekends = 48 - weekendsHome;
        double playSofia = 3.0 * sofiaWeekends / 4 + 2.0 * holidays / 3;
        double playTotal = playSofia + weekendsHome;

        if (year.Equals("leap"))
        {
            playTotal = Math.Floor(playTotal * 15 / 100 + playTotal);
        }
        else if (year.Equals("normal"))
        {
            playTotal = Math.Floor(playTotal);
        }
        Console.WriteLine(playTotal);
    }
}
