namespace Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area Calculator");
            var figure = Console.ReadLine().ToLower();
            if (figure == "square")
            {
                var size = float.Parse(Console.ReadLine());
                var area = size * size;
                Console.WriteLine(size);
            }

            if (figure == "rectangle")
            {
                var size1 = float.Parse(Console.ReadLine());
                var size2 = float.Parse(Console.ReadLine());
                var area = size1 * size2;
                Console.WriteLine(area);
            }

            if (figure == "circle")
            {
                var radius = float.Parse(Console.ReadLine());
                var area = radius * radius * Math.PI;
                Console.WriteLine(area);
            }

            if (figure == "triangle")
            {
                var side = float.Parse(Console.ReadLine());
                var height = float.Parse(Console.ReadLine());
                var area = side * height * 0.5;
                Console.WriteLine(area);
            }
        }
    }
}
