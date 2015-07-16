using Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes.Model
{
    [ClassAttributes()]
    class TestCaseCalculator
    {
        [Ignore()]
        public void AddNumbers()
        {
            Console.WriteLine("i am in method add number");
        }
        [MethodAttribute()]
        public void SubtractNumbers()
        {
            Console.WriteLine("i am in method subtract number");
        }
        [MethodAttribute()]
        public void MultiplyNumbers()
        {
            Console.WriteLine("i am in method multiply number");
        }
    }
}
