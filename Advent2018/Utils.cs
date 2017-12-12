using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent2018
{
    public static class Utils
    {
        public static string FetchInput(int day)
        {
            return File.ReadAllText($"Inputs\\Day_{day}.txt");
        }

        public static List<IList<int>> InputMatrixToList(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var res = new List<IList<int>>();
            foreach (var line in lines)
            {
                var row = new List<int>();
                res.Add(row);
                var numbers = line.Replace(" ", "\t").Split("\t");
                foreach (var number in numbers)
                {
                    row.Add(int.Parse(number));
                }
            }

            return res;
        }
    }
}
