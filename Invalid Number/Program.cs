namespace Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200) || num == 0;
            if (!inRange)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("In Range");
            }
        }
    }
}
