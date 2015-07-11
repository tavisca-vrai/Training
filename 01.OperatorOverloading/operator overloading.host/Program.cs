using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operator_overloading.model;
using OperatorOverloading.DBL;
using OperatorOverloading.Parser;

namespace operator_overloading.host
{
    class OperatorOver
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the source currency");
                string sourceCurrency = Console.ReadLine();
                sourceCurrency = sourceCurrency.ToUpper();
                double amount,money;
                while (double.TryParse(Console.ReadLine(), out amount) == false)
                {
                    Console.WriteLine("Please enter proper amount for source money object:");
                }
                Console.WriteLine("enter the Target currency");
                string targetCurrency = Console.ReadLine();
                targetCurrency = targetCurrency.ToUpper();
                Money input = new Money();
                double ans = input.ConvertCurrency(sourceCurrency, targetCurrency,amount,out money);
                Console.WriteLine("the rate is: {0}", ans);
                Console.WriteLine("the converted amount is: {0}", money);
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
