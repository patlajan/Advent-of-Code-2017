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
            var tests = new string[] { "abcde fghij", "abcde xyz ecdab", "a ab abc abd abf abj", "iiii oiii ooii oooi oooo", "oiii ioii iioi iiio" };
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
       
        }
    }
}
