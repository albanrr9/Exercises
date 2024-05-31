namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int stayingDays = int.Parse(Console.ReadLine());

            double appsPrice = 0;
            double stdPrice = 0;

            if (month == "may" || month == "october")
            {
                appsPrice = 65;
                stdPrice = 50;
                if (stayingDays > 7 && stayingDays < 14)
                {
                    stdPrice *= 0.95;
                }
                if (stayingDays > 14)
                {
                    stdPrice *= 0.7;
                    appsPrice *= 0.9;
                }
            }
            else if (month == "june" || month == "september")
            {
                appsPrice = 68.70;
                stdPrice = 75.20;
                if (stayingDays > 14)
                {
                    stdPrice *= 0.8;
                    appsPrice *= 0.9;
                }
            }
            else if (month == "july" || month == "august")
            {
                appsPrice = 77;
                stdPrice = 76;
                
                if (stayingDays > 14)
                {
                    appsPrice *= 0.9;
                }
            }

            var appsTotal = appsPrice * stayingDays;
            var stdTotal = stdPrice * stayingDays;

            Console.WriteLine($"Apartment: {appsTotal:F2} lv.");
            Console.WriteLine($"Studio: {stdTotal:F2} lv.");
        }
    }
}
