namespace Point_on_a_Rectangle_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var onTopSide = (y == y1) && (x >= x1) && (x <= x2);
            var onBottomSide = (y == y2) && (x >= x1) && (x <= x2);

            if (onLeftSide || onRightSide || onTopSide || onBottomSide)
            {
                Console.WriteLine("Border");
            }
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {

                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
