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
            string tempCurrency = "";
            double tempAmount = 0.0;
            try
            {

                Console.WriteLine("enter the type of currency and amount of currency ");
                double.TryParse(Console.ReadLine(), out tempAmount);
                tempCurrency = Console.ReadLine();
                Console.WriteLine("enter the type of currency and amount of currency");
                double.TryParse(Console.ReadLine(), out tempAmount); 
                tempCurrency = Convert.ToString(Console.ReadLine());
                Money input1 = new Money(tempAmount,tempCurrency );
                Money input2 = new Money(tempAmount,tempCurrency );
                Money Output = input1 + input2;

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
