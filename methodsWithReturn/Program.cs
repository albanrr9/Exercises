namespace methodsWithReturn
{
    internal class Program
    {
        static string ReadFullName()

        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;

        }
        static void Main(string[] args)
        {
            ReadFullName();
        }
    }
}