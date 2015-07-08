using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading.model
{
    [Serializable]
    public class AmountException : Exception
    {

        public AmountException(string msg1):base(msg1)
        {
           
        }

        
    }
}

