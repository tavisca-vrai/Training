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
                Money x = new Money(tempCurrency, tempAmount);
                Money y = new Money(tempCurrency, tempAmount);
                Money z = new Money(tempCurrency, tempAmount);
                z = x + y;
                Console.WriteLine("the total amount is: " + z.Currency + " " + z.Amount);
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
