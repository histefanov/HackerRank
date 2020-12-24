using System;
using System.Linq;

namespace TimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var clockMap = new[]
            {"o' clock", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
             "eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen", "eighteen",
             "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five",
             "twenty six", "twenty seven", "twenty eight", "twenty nine", "half"};

            string result;

            if (minutes == 0)
            {
                result = clockMap[hour] + " " + clockMap[minutes];
            }
            else if (minutes <= 30)
            {
                string mid;

                if (minutes == 15 || minutes == 30)
                {
                    mid = " past ";
                }
                else if (minutes == 1)
                {
                    mid = " minute past ";
                }
                else
                {
                    mid = " minutes past ";
                }

                result = clockMap[minutes] + mid + clockMap[hour];
            }
            else
            {
                var remainingMinutes = 60 - minutes;
                string mid; 

                if (remainingMinutes == 15 || remainingMinutes == 30)
                {
                    mid = " to ";
                }
                else if (remainingMinutes == 1)
                {
                    mid = " minute to ";
                }
                else
                {
                    mid = " minutes to ";
                }
                var nextHour = hour == 12 ? 1 : hour + 1;
                result = clockMap[remainingMinutes] + mid + clockMap[nextHour];
            }

            Console.WriteLine(result);
        }        
    }
}
