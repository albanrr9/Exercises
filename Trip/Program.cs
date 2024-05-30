namespace Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double spentBudget = 0;
            string vacationType = null;
            string destination = null;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spentBudget = budget * 0.3;
                    vacationType = "Camp";

                }
                else if (season == "winter")
                {
                    spentBudget = budget * 0.7;
                    vacationType = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spentBudget = budget * 0.4;
                    vacationType = "Camp";
                }
                else if (season == "winter")
                {
                    spentBudget = budget * 0.8;
                    vacationType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spentBudget = budget * 0.9;
                vacationType = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}\n{1} - {2}", destination, vacationType, Math.Round(spentBudget, 2));
        }
    }
}
