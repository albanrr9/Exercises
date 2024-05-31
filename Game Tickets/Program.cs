namespace Game_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double totalTicketsPrice;
            double transportPrice = 0;
            double budgetLeft;

            if (ticketType == "vip")
            {
                ticketPrice = 499.99;
            }
            else if (ticketType == "normal")
            {
                ticketPrice = 249.99;
            }

            if (people >= 1 && people <= 4)
            {
                transportPrice = 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transportPrice = 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transportPrice = 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transportPrice = 0.4;
            }
            else if (people >= 50)
            {
                transportPrice = 0.25;
            }

            budgetLeft = budget - (budget * transportPrice);
            totalTicketsPrice = people * ticketPrice;
            budgetLeft -= totalTicketsPrice;

            if (budgetLeft < 0)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budgetLeft):F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budgetLeft:F2} leva left.");
            }
        }
    }
}
