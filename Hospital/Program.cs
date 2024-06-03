namespace Hospital;

internal class Program
{
    static void Main(string[] args)
    {
        int period = int.Parse(Console.ReadLine());

        int doctors = 7;
        int treatedPatients = 0;
        int untreatedPatients = 0;

        for (int i = 1; i <= period; i++)
        {
            int currentPatients = int.Parse(Console.ReadLine());
            if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                doctors++;
            }
            if (currentPatients > doctors)
            {
                treatedPatients += doctors;
                untreatedPatients += currentPatients - doctors;
            }
            else
            {
                treatedPatients += currentPatients;
            }
        }

        string output = string.Format($"Treated patients: {treatedPatients}\nUntreated patients: {untreatedPatients}");
        Console.WriteLine(output);
    }
}
