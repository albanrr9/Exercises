namespace Metric_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metric Converter");
            var size = double.Parse(Console.ReadLine());
            var from = Console.ReadLine().ToLower();
            var to = Console.ReadLine().ToLower();
            switch (from)
            {
                case "mm":
                    size = size / 1000;
                    break;
                case "m":
                    size = size / 1;
                    break;
                case "cm":
                    size = size / 100;
                    break;
                case "mi":
                    size = size / 0.000621371192;
                    break;
                case "in":
                    size = size / 39.3700787;
                    break;
                case "km":
                    size = size / 0.001;
                    break;
                case "ft":
                    size = size / 3.2808399;
                    break;
                case "yd":
                    size = size / 1.0936133;
                    break;
            }
            switch (to)
            {
                case "mm":
                    size = size * 1000;
                    break;
                case "m":
                    size = size * 1;
                    break;
                case "cm":
                    size = size * 100;
                    break;
                case "mi":
                    size = size * 0.000621371192;
                    break;
                case "in":
                    size = size * 39.3700787;
                    break;
                case "km":
                    size = size * 0.001;
                    break;
                case "ft":
                    size = size * 3.2808399;
                    break;
                case "yd":
                    size = size * 1.0936133;
                    break;
            }
            Console.WriteLine(size + " " + to);
        }
    }
}
