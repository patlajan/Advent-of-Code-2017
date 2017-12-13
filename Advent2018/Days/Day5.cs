using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advent2018
{
    public class Day5 : IDay
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
            var instructions = ParseInpit(input);

            var stepsCount = 0;
            var pos = 0;

            while (pos >= 0 && pos < instructions.Count)
            {
                var newPos = pos + instructions[pos];
                instructions[pos]++;
                pos = newPos;
                stepsCount++;
            }

            return stepsCount.ToString(); //360603 - correct
        }

        public string GetResult2(string input)
        {
            var instructions = ParseInpit(input);

            var stepsCount = 0;
            var pos = 0;

            while (pos >= 0 && pos < instructions.Count)
            {
                var newPos = pos + instructions[pos];

                if (instructions[pos] >= 3)
                    instructions[pos]--;
                else
                    instructions[pos]++;

                pos = newPos;
                stepsCount++;
            }

            return stepsCount.ToString(); //25347697 - correct
        }

        private List<int> ParseInpit(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var l = new List<int>();
            foreach (var line in lines)
            {
                l.Add(int.Parse(line));
            }

            return l;
        }
    }
}
