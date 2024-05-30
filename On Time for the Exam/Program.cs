namespace On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exam starting time (hours): ");
            var examHours = int.Parse(Console.ReadLine());
            Console.Write("Exam starting time (minutes): ");
            var examMinutes = int.Parse(Console.ReadLine());
            Console.Write("Arrival time (hours): ");
            var arrivalHours = int.Parse(Console.ReadLine());
            Console.Write("Arrival time (minutes): ");
            var arrivalMinutes = int.Parse(Console.ReadLine());

            string late = "Late";
            string onTime = "On time";
            string early = "Early";

            int examTime = (examHours * 60) + examMinutes;
            int arrivalTime = (arrivalHours * 60) + arrivalMinutes;
            int totalMinutesDifference = arrivalTime - examTime;

            string studentArrival = late;
            if (totalMinutesDifference < -30)
            {
                studentArrival = early;
            }
            else if (totalMinutesDifference <= 30)
            {
                studentArrival = onTime;
            }

            string result = string.Empty;
            if (totalMinutesDifference != 0)
            {
                int hoursDifference = Math.Abs(totalMinutesDifference / 60);
                int minutesDifference = Math.Abs(totalMinutesDifference % 60);

                if (hoursDifference > 0)
                {
                    result = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);
                }
                else
                {
                    result = minutesDifference + " minutes";
                }

                if (totalMinutesDifference < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }
            }

            Console.WriteLine(studentArrival);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
