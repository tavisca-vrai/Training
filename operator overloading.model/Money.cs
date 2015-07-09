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
            if (string.IsNullOrWhiteSpace(moneyString))
            {
                throw new NullReferenceException(Messages.CurrencyNull);
            }
            string[] split = moneyString.Split(' ');
            if (split.Length != 2)
            {
                throw new System.Exception(Messages.InvalidFormat);
            }

            double money;
            
            if (double.TryParse(split[0], out money) == false)
            {
                throw new System.ArgumentException(Messages.AmountNull);
            }
    
                Amount = money;
                if (string.IsNullOrWhiteSpace(split[1]))
                {
                    throw new NullReferenceException(Messages.CurrencyNull);
                }
                Currency = split[1];
        }

        public Money(double amount,string currency)
        {

            Currency = currency;
            Amount = amount;
        }
        public string Currency
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value)||value.Length!=3)
                {
                    throw new NullReferenceException(Messages.CurrencyNull);
                }
                _currency = value;
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
                if (double.IsPositiveInfinity(value)||value==double.MaxValue||value<0)
                {
                    throw new AmountException(Messages.AmountInavlid);
                }
                
                    _amount = value;
            }
            get
            {
                return _amount;
            }
        }

        public static Money operator +(Money inputOne, Money inputTwo)
        {
            if (inputOne._currency.Equals(inputTwo._currency, StringComparison.OrdinalIgnoreCase)==false)
            {
                throw new CurrencyException(Messages.CurrencyMismatch);
            }
             return (new Money( inputOne._amount + inputTwo._amount, inputOne._currency));
            }
      
        }

    }
}
        
        
        
   
        


