using System;
using System.Linq;
using System.Text;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var convertedTime = ConvertTo24HourFormat(time);

            Console.WriteLine(convertedTime);
        }

        private static object ConvertTo24HourFormat(string time)
        {
            var sb = new StringBuilder();
            var daytimeFormat = time.Substring(time.Length - 2);
            var hours = int.Parse(time.Substring(0, 2));

            if (daytimeFormat == "AM")
            {
                if (hours != 12)
                {
                    sb.Append(time.Substring(0, time.Length - 2));
                }
                else
                {
                    sb.Append("00").Append(time.Substring(2, time.Length - 4));
                }
            }
            else
            {                
                string convertedHours;

                if (hours != 12)
                {
                    convertedHours = (hours + 12).ToString();
                }
                else
                {
                    convertedHours = "12";
                }

                sb.Append(convertedHours).Append(time.Substring(2, time.Length - 4));
            }

            return sb.ToString();
        }
    }
}
