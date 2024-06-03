namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());

            double minibus = 0;
            double truck = 0;
            double train = 0;
            int tonnage = 0;

            for (int i = 0; i < cargo; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                tonnage += weight;
                if (weight <= 3)
                {
                    minibus += weight;
                }
                else if (weight > 3 && weight <= 11)
                {
                    truck += weight;
                }
                else if (weight > 11)
                {
                    train += weight;
                }
            }

            double byMinibus = minibus / tonnage * 100.00;
            double byTruck = truck / tonnage * 100.00;
            double byTrain = train / tonnage * 100.00;

            double avgPerTon = ((200 * minibus) + (175 * truck) + (120 * train)) / tonnage;

            string output = string.Format($"{avgPerTon:F2}\n{byMinibus:F2}%\n{byTruck:F2}%\n{byTrain:F2}%");
            Console.WriteLine(output);
        }
    }
}
