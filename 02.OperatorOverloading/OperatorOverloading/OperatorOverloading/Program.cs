using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Model;
using OperatorOverloading.DBL;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the type of currency and amount of currency ");
                Money input1 = new Money(Console.ReadLine());
                Console.WriteLine("enter the Target currency");
                string targetCurrency = Console.ReadLine();
                targetCurrency = targetCurrency.ToUpper();
                var ans = input1.ConvertCurrency(targetCurrency);
                //Money ans = new Money(string);
                //ans.ConvertCurrency(targetCurrency);
                Console.WriteLine("the converted amount is: {0}", ans);
                /*Console.WriteLine("enter the type of currency and amount of currency ");
                Money input1 = new Money(Console.ReadLine());
                Console.WriteLine("enter the type of currency and amount of currency");
                Money input2 = new Money(Console.ReadLine());
                Money output = input1 + input2;
                Console.WriteLine("the total amount is: " + Output.Currency + " " + Output.Amount);*/

            }
            catch (Exception e)
            {
                Console.WriteLine("the exception is: {0}", e.Message);

            }
            Console.ReadKey();

        }
    }
}
