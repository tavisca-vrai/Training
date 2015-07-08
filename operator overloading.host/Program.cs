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
            string tempCurrency="";
            double tempAmount=0.0;
            try
            {
                
                Console.WriteLine("enter the type of currency and amount of currency ");
                tempCurrency = Console.ReadLine();
                double.TryParse(Console.ReadLine(), out tempAmount);
                Console.WriteLine("enter the type of currency and amount of currency");
                tempCurrency = Convert.ToString(Console.ReadLine());
                tempAmount = Convert.ToDouble(Console.ReadLine());
                Money Input1 = new Money(tempCurrency, tempAmount);
                Money Input2 = new Money(tempCurrency, tempAmount);
                Money Output = Input1 + Input2;
                Console.WriteLine("the total amount is: " + Output.Currency + " " + Output.Amount);
            }
            catch (AmountException e1)
            {
                Console.WriteLine("the exception is: {0}", e1.Message);

            }

            catch (CurrencyException e2)
            {
                Console.WriteLine("the exception is: {0}", e2.Message);
            }
            catch (NullReferenceException e3)
            {
                Console.WriteLine("the exception is: {0}", e3.Message);
            }
            Console.ReadKey();
        }
    }
}
