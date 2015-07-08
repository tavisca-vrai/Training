using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace operator_overloading.model
{
    public class Money
    {
        private string currency;
        private double amount;
        private string word;

        public Money(string currency1, double amount1)
        {

            Currency = currency1;
            Amount = amount1;
        }
        public string Currency
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException(Messages.CurrencyNull);
                }
                else
                {
                    currency = value;
                }

            }
            get
            {
                return currency;
            }
        }
        public double Amount
        {
            set
            {
                amount = value;
            }
            get
            {
                return amount;
            }
        }

        public static Money operator +(Money a, Money b)
        {
            string tempC;
            double tempA;
            if (a.currency.Equals(b.currency, StringComparison.OrdinalIgnoreCase))
            {
                tempC = a.currency.ToUpper();
                tempA = a.amount + b.amount;
                if (double.IsPositiveInfinity(tempA) == false)
                {
                    return (new Money(tempC, tempA));
                }
                else
                {
                    throw new AmountException(Messages.amountexceed);
                }


            }
            else
            {
                throw new CurrencyException(Messages.currencymismatch);
            }


        }

    }
}
        
        
        
   
        


