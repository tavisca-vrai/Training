using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(
         AttributeTargets.Method)]
    public class AttributeCategory : System.Attribute
    {
        private string category;
        public AttributeCategory(string catego)
        {
            category = catego;
        }
        public string Category
        {
            get
            {
                return category;
            }
        }
    }
}
