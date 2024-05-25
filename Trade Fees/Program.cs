namespace Trade_Fees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trade Fees");
            string city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (0 <= sales && sales <= 500)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.05;
                }
                if (city == "varna")
                {
                    commission = sales * 0.045;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.055;
                }
                Console.WriteLine(Math.Round(commission, 2));
            }
            if (500 < sales && sales <= 1000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.07;
                }
                if (city == "varna")
                {
                    commission = sales * 0.075;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.08;
                }
                Console.WriteLine(Math.Round(commission, 2));
            }
            if (1000 < sales && sales <= 10000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.08;
                }
                if (city == "varna")
                {
                    commission = sales * 0.1;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.12;
                }
                Console.WriteLine(Math.Round(commission, 2));
            }
            if (sales > 10000)
            {
                if (city == "sofia")
                {
                    commission = sales * 0.12;
                }
                if (city == "varna")
                {
                    commission = sales * 0.13;
                }
                if (city == "plovdiv")
                {
                    commission = sales * 0.145;
                }
                Console.WriteLine(Math.Round(commission, 2));
            }
            if (sales < 0)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
