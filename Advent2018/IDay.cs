using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2018
{
    interface IDay
    {
        string GetResult1(string input);
        string GetResult2(string input);
        void RunTests();
    }
}
