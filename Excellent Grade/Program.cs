namespace Excellent_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excellent Grade");
            Console.Write("Enter your grade:");
            var grade = float.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
