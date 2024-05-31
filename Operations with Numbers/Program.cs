namespace Operations_with_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            decimal result = 0.00M;
            string evenOdd = "odd";

            if (mathOperator == '+')
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine(num1 + " " + mathOperator + " " + num2 + " = " + result + " - " + evenOdd);
            }
            else if (mathOperator == '-')
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine(num1 + " " + mathOperator + " " + num2 + " = " + result + " - " + evenOdd);
            }
            else if (mathOperator == '*')
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine(num1 + " " + mathOperator + " " + num2 + " = " + result + " - " + evenOdd);
            }
            else if (mathOperator == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                    return;
                }
                result = num1 / num2;
                Console.WriteLine(num1 + " " + mathOperator + " " + num2 + $" = {result:F2}");
            }
            else if (mathOperator == '%')
            {
                result = num1 % num2;
                Console.WriteLine(num1 + " " + mathOperator + " " + num2 + " = " + result);
            }

            
        }
    }
}
