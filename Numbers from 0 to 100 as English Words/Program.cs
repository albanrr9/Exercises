namespace Numbers_from_0_to_100_as_English_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 0 to 100 as English Words");
            Console.Write("Write a number: ");
            var num = int.Parse(Console.ReadLine());
            string numStr = num.ToString();
            char[] digitsArray = numStr.ToCharArray();
            int ones = int.Parse(digitsArray[digitsArray.Length - 1].ToString());
            int tens = int.Parse(digitsArray[digitsArray.Length - 2].ToString());
            string teen = "";
            string secondDigit = "";
            string firstDigit = "";
            if (tens == 1)
            {
                switch (ones)
                {
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1:
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        teen = "thir";
                        break;
                    case 4:
                        teen = "four";
                        break;
                    case 5:
                        teen = "fif";
                        break;
                    case 6:
                        teen = "six";
                        break;
                    case 7:
                        teen = "seven";
                        break;
                    case 8:
                        teen = "eigh";
                        break;
                    case 9:
                        teen = "nine";
                        break;
                }
                if (ones >= 3 && ones <= 9)
                {
                    Console.WriteLine(teen + "teen");
                }
            }
            
            if (tens > 1)
            {
                switch (tens)
                {
                    case 0:
                        switch (ones)
                        {
                            case 0:
                                firstDigit = "zero";
                                break;
                            case 1:
                                firstDigit = "one";
                                break;
                            case 2:
                                firstDigit = "two";
                                break;
                            case 3:
                                firstDigit = "three";
                                break;
                            case 4:
                                firstDigit = "four";
                                break;
                            case 5:
                                firstDigit = "five";
                                break;
                            case 6:
                                firstDigit = "six";
                                break;
                            case 7:
                                firstDigit = "seven";
                                break;
                            case 8:
                                firstDigit = "eight";
                                break;
                            case 9:
                                firstDigit = "nine";
                                break;
                        }
                        break;
                    case 2:
                        secondDigit = "twenty ";
                        break;
                    case 3:
                        secondDigit = "thirty ";
                        break;
                    case 4:
                        secondDigit = "forty ";
                        break;
                    case 5:
                        secondDigit = "fifty ";
                        break;
                    case 6:
                        secondDigit = "sixty ";
                        break;
                    case 7:
                        secondDigit = "seventy ";
                        break;
                    case 8:
                        secondDigit = "eighty ";
                        break;
                    case 9:
                        secondDigit = "ninty ";
                        break;
                }
                switch (ones)
                {
                    case 0:
                        firstDigit = "";
                        break;
                    case 1:
                        firstDigit = "one";
                        break;
                    case 2:
                        firstDigit = "two";
                        break;
                    case 3:
                        firstDigit = "three";
                        break;
                    case 4:
                        firstDigit = "four";
                        break;
                    case 5:
                        firstDigit = "five";
                        break;
                    case 6:
                        firstDigit = "six";
                        break;
                    case 7:
                        firstDigit = "seven";
                        break;
                    case 8:
                        firstDigit = "eight";
                        break;
                    case 9:
                        firstDigit = "nine";
                        break;
                }
                Console.WriteLine(secondDigit + firstDigit);
            }
            if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
        }
    }
}
