using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading.model
{
   public class AmountException:Exception
    {
    
        public AmountException(string msg1)
        {
            Message1 = msg1;
        }
       
        public string Message1{get;set;}
       
        
    }
}

    