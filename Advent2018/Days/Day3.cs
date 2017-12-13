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
            foreach(var i in "2 5 9 10 13 18 49".Split(" "))
            {
                Console.WriteLine($"{i}: {GetResult2(i.ToString())}");
            }
        }

        public string GetResult1(string input)
        {
            var memAddress = int.Parse(input);

            if (memAddress == 1) return "0";

            var addrSqrt = Math.Sqrt(memAddress);

            var spiralN = Math.Round(addrSqrt / 2); //spiralN = spiral number = the number of the "layer" which the cell is on

            if (addrSqrt == (int) addrSqrt) // exception for the the last address in the layer
            {
                spiralN--;
            }

            var rowLen = spiralN * 2; //how many addresses contains each row or col in the current layer - 1

            var startAddrOfSpiral = Math.Pow(spiralN * 2 - 1, 2) + 1; //the first address of the layer

            var posInSpiral = memAddress - startAddrOfSpiral; //the position of the cell relative to the 1st cell in the layer

            var relativeSpiralRowPos = posInSpiral % rowLen + 1; //the position of the cell relative to start of the row/col

            var midRowPos = spiralN; //the position of the middle cell in the current row/col

            var distanceFromMid = Math.Abs(relativeSpiralRowPos - midRowPos); //the further we are from the mid of the row, the further we are from the start address

            var absDistance = spiralN + distanceFromMid;

            return absDistance.ToString();
            //371 - Correct
        }

        public string GetResult2(string input)
        {
            //done by excel
            return "552146"; //too high
            return "369601"; //correct
        }
    }
}
