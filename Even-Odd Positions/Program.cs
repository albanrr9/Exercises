using System.Xml.Linq;

namespace Even_Odd_Positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = 99999999;
            double oddMax = -99999999;
            double evenSum = 0;
            double evenMin = 99999999;
            double evenMax = -99999999;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }
            string formattedString = $"OddSum={oddSum}\nOddMin={oddMin}\nOddMax={oddMax}\nEvenSum={evenSum}\nEvenMin={evenMin}\nEvenMax={evenMax}";
            Console.WriteLine(formattedString);
        }
    }
}
