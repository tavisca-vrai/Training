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
            Money x= new Money();
            Money y=new Money();
            Money z=new Money();
            try
            {
                Console.WriteLine("enter the type of currency and amount of currency ");
                x.currency=Convert.ToString(Console.ReadLine());
                x.amount=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the type of currency and amount of currency");
                 y.currency=Convert.ToString(Console.ReadLine());
                y.amount=Convert.ToDouble(Console.ReadLine());
                z = x + y;
                Console.WriteLine("the total amount is: " + z.currency + " " + z.amount);
            }
            catch (AmountException e1)
            {
                Console.WriteLine("the exception is: {0}", e1.Message1);

            }

            catch (CurrencyException e2)
            {
                Console.WriteLine("the exception is: {0}", e2.Message);
            }
            Console.ReadKey();
        }
    }
}
