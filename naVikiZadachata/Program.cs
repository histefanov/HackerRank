using System;

namespace naVikiZadachata
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidaysCount = int.Parse(Console.ReadLine());
            var hometownWeekendsCount = int.Parse(Console.ReadLine());

            var sofiaWeekendsCount = 48 - hometownWeekendsCount;
            var saturdayGamesInSofia = sofiaWeekendsCount * 0.75;
            var sundayGamesAtHome = hometownWeekendsCount;
            var holidayGamesCount = holidaysCount * (2 / 3.0);

            var totalGamesPlayed = saturdayGamesInSofia + sundayGamesAtHome + holidayGamesCount;

            if (year == "leap") totalGamesPlayed *= 1.15;

            Console.WriteLine(Math.Floor(totalGamesPlayed));
        }
    }
}
