using System;

namespace Advent2018
{
    class Program
    {
        private const int Day = 3
            ;

        static IDay DayFactory(int day)
        {
            return (IDay)Activator.CreateInstance(Type.GetType($"Advent2018.Day{day}"));
        }

        static void Main(string[] args)
        {
            var input = Utils.FetchInput((Day));
            var day = DayFactory(Day);

            day.RunTests();

            var res = day.GetResult1(input);
            Console.WriteLine(res);
            Console.WriteLine("-------------");

            res = day.GetResult2(input);
            Console.WriteLine(res);

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }

    }
}
