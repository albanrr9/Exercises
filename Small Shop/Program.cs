namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            int quantity = int.Parse(Console.ReadLine());
            float price = 0;
            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.5f;
                }
                if (product == "water")
                {
                    price = quantity * 0.8f;
                }
                if (product == "beer")
                {
                    price = quantity * 1.2f;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.45f;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.6f;
                }
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.4f;
                }
                if (product == "water")
                {
                    price = quantity * 0.7f;
                }
                if (product == "beer")
                {
                    price = quantity * 1.15f;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.3f;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.5f;
                }
            }
            if (town == "varna")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45f;
                }
                if (product == "water")
                {
                    price = quantity * 0.7f;
                }
                if (product == "beer")
                {
                    price = quantity * 1.1f;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.35f;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.55f;
                }
            }
            Console.WriteLine(price);
        }
    }
}