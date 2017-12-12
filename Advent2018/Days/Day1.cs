using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2018
{
    public class Day1 : IDay
    {
        public string GetResult1(string input)
        {
            return Count(input).ToString();

            //242 - too low
            //1044 - correct
        }

        public string GetResult2(string input)
        {
            return Count(input, input.Length / 2).ToString();
            //1054 - correct
        }

        public void RunTests()
        {
            
        }

        public int Count(string input, int step = 1)
        {
            var sum = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == input[(i + step) % input.Length]) sum += int.Parse(input[i].ToString());
            }

            return sum;
        }

    }
}
