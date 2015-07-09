using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operator_overloading.model;

namespace operator_overloading.host
{
    class OperatorOver
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("enter the type of currency and amount of currency ");
                Money input1 = new Money(Console.ReadLine());
                Console.WriteLine("enter the type of currency and amount of currency");
                Money input2 = new Money(Console.ReadLine());
                Money Output = input1 + input2;
                Console.WriteLine("the total amount is: " + Output.Currency + " " + Output.Amount);
            }
            catch (Exception e)
            {
                Console.WriteLine("the exception is: {0}", e.Message);

            }
            Console.ReadKey();
        }
    }
}
