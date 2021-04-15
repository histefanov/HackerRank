using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            var nthDay = int.Parse(Console.ReadLine());

            var outreachCount = GetPeopleReached(nthDay);

            Console.WriteLine(outreachCount);
        }

        public static int GetPeopleReached(int nthDay)
        {
            int likesCount = 0;
            int recipients = 5;

            for (int i = 0; i < nthDay; i++)
            {
                likesCount += recipients / 2;
                recipients = recipients / 2 * 3;
            }

            return likesCount;
        }
    }
}
