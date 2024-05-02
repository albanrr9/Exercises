namespace Pipes_in_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pipes in Pool");
            Console.Write("Enter volume of the pool in liters: ");
            int volume = int.Parse(Console.ReadLine());
            Console.Write("Enter flow rate of the first pipe per hour: ");
            int pipe1 = int.Parse(Console.ReadLine());
            Console.Write("Enter flow rate of the second pipe per hour: ");
            int pipe2 = int.Parse(Console.ReadLine());
            Console.Write("Enter hours that the worker is absent: ");
            float hours = float.Parse(Console.ReadLine());

            float pipes = pipe1 + pipe2;
            float pipe1con = pipe1 / pipes;
            float pipe2con = pipe2 / pipes;
            float water = pipes * hours;

            if (water <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(water / volume * 100),
                    Math.Truncate(pipe1con * 100),
                    Math.Truncate(pipe2con * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
            }


        }
    }
}
