namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harvest!");
            Console.Write("The vineyard size:");
            int vineyardSize = int.Parse(Console.ReadLine());
            Console.Write("Grapes for 1m​²:");
            float grapePerMeterSquare = float.Parse(Console.ReadLine());
            Console.Write("Needed liters of wine:");
            int neededWine = int.Parse(Console.ReadLine());
            Console.Write("Number of workers:");
            int workers = int.Parse(Console.ReadLine());

            float areaForWine = vineyardSize * 0.4f;
            float extractedGrape = areaForWine * grapePerMeterSquare;
            float wineProduced = extractedGrape / 2.5f;

            if (wineProduced < neededWine)
            {
                float insufficientWine = neededWine - wineProduced;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(insufficientWine));
            }
            else
            {
                float wineLeft = wineProduced - neededWine;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Ceiling(wineProduced));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / workers));
            }


        }
    }
}
