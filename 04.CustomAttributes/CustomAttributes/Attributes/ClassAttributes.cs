using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class)] 
    public class ClassAttributes : System.Attribute
    {
       public static bool Exists(Type type)
       {
           foreach (var attribute in type.GetCustomAttributes(false))
           {
               if (attribute is ClassAttributes) return true;
           }
           return false;
       }
    }
}
