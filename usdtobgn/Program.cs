namespace usdtobgn
{
    public class CurrencyConverter
    {
        private double[,] conversionRates;

        public CurrencyConverter()
        {
            conversionRates = new double[,]
            {
                {1, 0.91887, 1.79549, 0.70877},
                {1.08946, 1, 1.95583, 0.77155},
                {0.55709, 0.51130, 1, 0.39488},
                {1.41014, 1.29543, 2.53405, 1}
            };  
        }

        public double ConvertCurrency(double amount, int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || fromIndex >= conversionRates.GetLength(0) || toIndex < 0 || toIndex >= conversionRates.GetLength(1))
            {
                throw new ArgumentException("Invalid currency index.");
            }
            return amount * conversionRates[fromIndex, toIndex];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter converter = new CurrencyConverter();

            Console.WriteLine("Currency Converter");

            Console.Write("Enter number you want to convert:");
            double currency = double.Parse(Console.ReadLine());

            Console.WriteLine("From:");
            var from = Console.ReadLine();

            Console.WriteLine("To:");
            var to = Console.ReadLine();

            int fromCurrencyIndex = 0;
            int toCurrencyIndex = 0;

            switch (from)
            {
                case "USD":
                    fromCurrencyIndex = 0;
                    break;
                case "EUR":
                    fromCurrencyIndex = 1;
                    break;
                case "BGN":
                    fromCurrencyIndex = 2;
                    break;
                case "GBP":
                    fromCurrencyIndex = 3;
                    break;
            }

            switch (to)
            {
                case "USD":
                    toCurrencyIndex = 0;
                    break;
                case "EUR":
                    toCurrencyIndex = 1;
                    break;
                case "BGN":
                    toCurrencyIndex = 2;
                    break;
                case "GBP":
                    toCurrencyIndex = 3;
                    break;
            }
            Console.WriteLine($"From index: {fromCurrencyIndex}, To index: {toCurrencyIndex}");


            double convertedAmount = converter.ConvertCurrency(currency, fromCurrencyIndex, toCurrencyIndex);
            Console.WriteLine($"{Math.Round(convertedAmount, 2)} {to}");
        }
    }
}
