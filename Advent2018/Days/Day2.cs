using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2018
{
    public class Day2 : IDay
    {
        public string GetResult1(string input)
        {
            var matrix = Utils.InputMatrixToList(input);

            var checkSum = 0;
            foreach (var row in matrix)
            {
                var max = row[0];
                var min = row[0];
                foreach (var cell in row)
                {
                    min = Math.Min(min, cell);
                    max = Math.Max(max, cell);
                }

                checkSum += max - min;
            }

            return checkSum.ToString();
            //41887 - correct
        }

        public string GetResult2(string input)
        {
            var matrix = Utils.InputMatrixToList(input);

            var checkSum = 0;
            foreach (var _row in matrix)
            {
                var row = _row.ToArray();
                Array.Sort(row);
                var shouldBreak = false;

                for (int i = 0; i < row.Length - 1; i++)
                {
                    for (int j = i + 1; j < row.Length; j++)
                    {
                        if (row[j] % row[i] == 0)
                        {
                            checkSum += row[j] / row[i];
                            shouldBreak = true;
                            break;
                        }

                        if (shouldBreak) break;
                    }
                }
            }

            return checkSum.ToString();
            //226 - correct
        }

        public void RunTests()
        {
            
        }
    }
}
