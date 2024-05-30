namespace Point_in_the_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool outRectangle1 = (x < 0 || x > h * 3 || y < 0 || y > h);
            bool outRectangle2 = (x < h || x > h * 2 || y < h || y > h * 4);
            
            bool inRectangle1 = (x > 0 && x < h * 3 && y > 0 &&  y < h);
            bool inRectangle2 = (x > h && x < h * 2 && y > h && y < h * 4);
            
            bool commonBorder = (x >= h && x <= 2 * h && y == h);

            if (outRectangle1 && outRectangle2)
            {
                Console.WriteLine("outside");
            }
            else if (inRectangle1 || inRectangle2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
