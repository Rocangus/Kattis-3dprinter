using System;

namespace Kattis_3dprinter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var targetStatues = int.Parse(input);
            Console.WriteLine(DaysRequired(targetStatues));
        }

        public static int DaysRequired(int target)
        {
            int days = int.MaxValue;

            for (int i = 0; i <= target; i++)
            {
                int printers = (int)Math.Pow(2, i);
                int attemptDays = i + (int)Math.Ceiling((double)target / printers);
                if (attemptDays >= days)
                {
                    break;
                }
                days = attemptDays;
            }
            return days;
        }
    }
}
