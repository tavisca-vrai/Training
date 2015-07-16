using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Server
    {
        private Listener listener;
        private Dispatcher dispatcher = new Dispatcher();


        public Server(string host, int port)
        {
            this.listener = new Listener(host, port);

        }



        public void Start()
        {
            Task.Run(() =>
            {
                listener.Listen();
            });
            Task.Run(() =>
            {
                dispatcher.Start();
            });

        }

        public void Stop()
        {
            listener.Stop();
            dispatcher.Stop();
        }
    }
}
