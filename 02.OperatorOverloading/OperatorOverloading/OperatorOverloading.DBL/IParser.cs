using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.DBL
{
    interface IParser
    {
        double GetConversionRate(string intialCurrency1, string finalCurrency);
    }
}
