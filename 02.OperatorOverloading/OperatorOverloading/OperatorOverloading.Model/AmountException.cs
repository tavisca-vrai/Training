using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
    [Serializable]
    class AmountException : Exception
    {
        public AmountException(string msg1)
            : base(msg1)
        {

        }
        protected AmountException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
