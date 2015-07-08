using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading.model
{
    [Serializable]
    public class CurrencyException:Exception
    {
        
        public CurrencyException(string msg):base(msg)
         {
             
         }

        protected CurrencyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
       }
    }

