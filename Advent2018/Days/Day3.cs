using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advent2018
{
    public class Day3 : IDay
    {
        public void RunTests()
        {
        }

        public string GetResult1(string input)
        {
            var endPos = Math.Ceiling(Math.Sqrt(int.Parse(input)));

            var spiralN = (endPos + 1) / 2;

            var maxDist = spiralN * 2;

            return spiralN.ToString();
        }

        public string GetResult2(string input)
        {
            return "";
        }

        // (prev + 2 ) * 4 || min = 1
        // 1, 8, 16, 24, 32, 40

        //this happens on spira 99.

        //var sum = 0;
        //for (var i = 0; i< 300; i += 2)
        //{
        //    var c = 4 * i;
        //    sum += c;
        //    Console.WriteLine($"{c} {sum}");
        //}
    }
}
