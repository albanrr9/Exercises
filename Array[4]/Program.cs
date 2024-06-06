namespace Array_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };

            int maxLength = 1;
            int currentLength = 1;
            int maxStartIndex = 0;
            int currentStartIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }
                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            int[] maximalSequence = ExtractSubarray(array, maxStartIndex, maxLength);

            // Output the subarray
            Console.WriteLine("Maximal sequence of consecutive equal elements:");
            Console.WriteLine(string.Join(", ", maximalSequence));
        }

        static int[] ExtractSubarray(int[] arr, int start, int length)
        {
            return arr.Skip(start).Take(length).ToArray();
        }
    }
}