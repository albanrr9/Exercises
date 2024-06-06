namespace Array_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first array length:");
            int array1Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Write first array elements:");
            int[] array1 = new int[array1Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Write second array length:");
            int array2Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second array elements:");
            int[] array2 = new int[array2Length];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            if (array1.Length != array2.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            Console.WriteLine(equal);
        }
    }
}