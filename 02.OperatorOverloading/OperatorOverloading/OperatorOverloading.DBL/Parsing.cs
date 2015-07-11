using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.DBL
{
    class Parsing
    {
        public string[] ParseIt(string input)
        {
            string[] split = input.Split('{');
            string[] secondSplit = split[2].Split(',');
            return secondSplit;
        }

    }
}
