using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace operator_overloading.model
{
    
    public class Money
    {
        private string _currency;
        private double _amount;
        public Money(string moneyString)
        {
            string[] split = moneyString.Split(' ');
            if (split.Length != 2)
            {
                throw new System.Exception(Messages.InvalidFormat);
            }

            double money;
            if ((double.TryParse(split[0], out money) == false))
            {
                throw new System.Exception(Messages.InvalidFormat);
            }
            else
            {
                Amount = money;
                Currency = split[1];
            }
        }

        public Money(double amount1,string currency1)
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
                    _currency = value;
                }

            }
            get
            {
                return _currency;
            }
        }
        public double Amount
        {
            set
            {
                if (double.IsNaN((double)value)==true)
                {
                    throw new System.NullReferenceException(Messages.AmountNull);
                }
                else
                {
                    _amount = value;
                }

                
            }
            get
            {
                return _amount;
            }
        }

        public static Money operator +(Money inputOne, Money inputTwo)
        {
            string tempCurrency;
            double tempAmount;
            if (inputOne._currency.Equals(inputTwo._currency, StringComparison.OrdinalIgnoreCase))
            {
                tempCurrency = inputOne._currency.ToUpper();
                tempAmount = inputOne._amount + inputTwo._amount;
                if (double.IsPositiveInfinity(tempAmount) == false)
                {
                    return (new Money(tempAmount,tempCurrency ));
                }
                else
                {
                    throw new AmountException(Messages.AmountExceed);
                }


            }
            else
            {
                throw new CurrencyException(Messages.CurrencyMismatch);
            }


        }

    }
}
        
        
        
   
        


