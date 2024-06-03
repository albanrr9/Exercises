namespace Smart_Lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int startingMoney = 0;
            int moneySaved = 0;
            int toys = 0;
            int selledToys;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    startingMoney += 10;
                    moneySaved = moneySaved + startingMoney - 1;
                }
                else
                {
                    toys++;
                }
            }

            selledToys = toys * toyPrice;
            moneySaved += selledToys;

            if (moneySaved > washingMachPrice)
            {
                Console.WriteLine($"Yes!\n{moneySaved - washingMachPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No!\n{washingMachPrice - moneySaved:F2}");
            }
        }
    }
}
