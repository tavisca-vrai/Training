﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(
         AttributeTargets.Method)]
       
    public class MethodAttribute : System.Attribute
    {
        
    }
}
