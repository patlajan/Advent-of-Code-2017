using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advent2018
{
    public class Day6 : IDay
    {
        public void RunTests()
        {
            var tests = new string[] { "0\r\n3\r\n0\r\n1\r\n-3" };
            foreach (var i in tests)
            {
                Console.WriteLine($"{i}: {GetResult2(i)}");
            }
        }

        public string GetResult1(string input)
        {
               
        }

        public string GetResult2(string input)
        {
            return "";
        }

        private List<int> ParseInpit(string input)
        {
            var numbers = input.Split("\t");
            var l = new List<int>();
            foreach (var number in numbers)
            {
                l.Add(int.Parse(number));
            }

            return l;
        }
    }
}
