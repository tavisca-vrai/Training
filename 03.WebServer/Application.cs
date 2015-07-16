using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Application
    {
        static Application()
        {
            RequestQueue = new Queue();
        }
        public static IQueue RequestQueue { get; private set; }
    }
}
