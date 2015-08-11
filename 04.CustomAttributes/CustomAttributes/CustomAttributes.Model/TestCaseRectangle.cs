using Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes.Model
{
    [ClassAttributes()]
    public class TestCaseRectangle
    {
        [AttributeCategory("smoke test")]
        [MethodAttribute()]
        public void Area(double length, double width)
        {
            Console.WriteLine("i am in method area");
        }
        public void Circumference(double length, double width)
        {
            Console.WriteLine("i am in method circumference");
        }
    }
}
