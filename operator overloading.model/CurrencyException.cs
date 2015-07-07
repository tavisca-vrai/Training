using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading.model
{
    public class CurrencyException:Exception
    {
        
        public CurrencyException(string msg)
         {
             Message = msg;
         }


        public string Message { get; set; }
       }
    }

