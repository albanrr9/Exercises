namespace Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Shop");
            Console.Write("Choose a fruit: ");
            string fruit = Console.ReadLine().ToLower();
            Console.Write("What day is today: ");
            string weekDay = Console.ReadLine().ToLower();
            Console.Write("How much KG of fruit you want: ");
            var quantity = double.Parse(Console.ReadLine());

            Dictionary<string, decimal> workingDays = new Dictionary<string, decimal>()
            {
                {"banana", 2.5m},
                {"apple", 1.2m},
                {"orange", 0.85m},
                {"grapefruit", 1.45m},
                {"kiwi", 2.7m},
                {"pineapple", 5.5m},
                {"grapes", 3.85m}
            };

            Dictionary<string, decimal> weekEndDays = new Dictionary<string, decimal>()
            {
                {"banana", 2.7m},
                {"apple", 1.25m},
                {"orange", 0.9m},
                {"grapefruit", 1.6m},
                {"kiwi", 3m},
                {"pineapple", 5.6m},
                {"grapes", 4.2m}
            };

            Dictionary<string, decimal> priceTable = workingDays;
            if (weekDay == "saturday" || weekDay == "sunday")
            {
                priceTable = weekEndDays;
            }
            if (priceTable.ContainsKey(fruit))
            {
                decimal pricePerKg = priceTable[fruit];
                decimal totalPrice = (decimal)quantity * pricePerKg;

                Console.WriteLine($"Total price for {quantity} kg of {fruit}: {totalPrice:F2}");
            }
        }
    }
}
