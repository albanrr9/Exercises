namespace Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personal Titles");
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms");
                }
            }
            else
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr");
                }
            }
        }
    }
}
