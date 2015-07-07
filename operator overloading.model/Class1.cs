using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace operator_overloading.model
{
    public class Money
    {
        public string currency;
        public double amount;
        

        public static Money operator+(Money a,Money b)
        {
            Money c= new Money();
            if ( a.amount - Double.MaxValue > b.amount || b.amount-Double.MaxValue > a.amount)
            {
                throw new AmountException("amount exceeds its limits");
            }
            if(a.currency.Equals(b.currency , StringComparison.OrdinalIgnoreCase))
            {
                c.currency=a.currency.ToUpper();
                c.amount=a.amount+b.amount;
                return c;
                
                
            }
            else
            {
                throw new CurrencyException("Currency mismatch");
            }
        }
    }
     
}
        
        
        
   
        


