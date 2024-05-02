namespace Transportation_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transportation Price");
            Console.Write("Enter distance in km:");
            int kilometers = int.Parse(Console.ReadLine());
            Console.Write("Enter period of the day (day or night):");
            string periodDay = Console.ReadLine().ToLower();
            double price;
            float taxiRate;
            float taxiFee = 0.7f;

            if (periodDay == "day")
            {
                taxiRate = 0.79f;
            }
            else
            {
                taxiRate = 0.9f;
            }

            if (kilometers < 20)
            {
                price = taxiFee + (kilometers * taxiRate);
            }
            else if (kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else
            {
                price = kilometers * 0.06;
            }


            Console.WriteLine(Math.Round(price, 2));

        }
    }
}
