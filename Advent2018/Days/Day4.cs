using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advent2018
{
    public class Day4 : IDay
    {
        public void RunTests()
        {
            var tests = new string[] { "abcde fghij", "abcde xyz ecdab", "a ab abc abd abf abj", "iiii oiii ooii oooi oooo", "oiii ioii iioi iiio" };
            foreach (var i in tests)
            {
                Console.WriteLine($"{i}: {GetResult2(i)}");
            }
        }

        public string GetResult1(string input)
        {
            var lines = input.Replace("\r", "\n").Split("\n",StringSplitOptions.RemoveEmptyEntries);
            var count = 0;

            foreach (var line in lines)
            {
                var foundDuplicate = false;
                var bag = new HashSet<string>();
                var words = line.Split(" ");
                foreach (var w in words)
                {
                    if (bag.Contains(w))
                    {
                        foundDuplicate = true;
                        break;
                    }

                    bag.Add(w);
                }

                if (!foundDuplicate)
                {
                    count++;
                }
            }

            //512 -- too high
            //466 - correct
            return count.ToString();
        }

        public string GetResult2(string input)
        {
            var lines = input.Replace("\r", "\n").Split("\n", StringSplitOptions.RemoveEmptyEntries);
            var count = 0;

            foreach (var line in lines)
            {
                var foundDuplicate = false;
                var bag = new HashSet<string>();
                var words = line.Split(" ");
                foreach (var w in words)
                {
                    var warr = w.ToCharArray();
                    Array.Sort(warr);
                    var wr = new string(warr);
                    if (bag.Contains(wr))
                    {
                        foundDuplicate = true;
                        break;
                    }

                    bag.Add(wr);
                }

                if (!foundDuplicate)
                {
                    count++;
                }
            }

            //447 - too high - searched for palindromes, instead of anagrams
            //251 - correct
            return count.ToString();
        }
    }
}
