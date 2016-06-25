using System;
using Microsoft.Owin.Hosting;

namespace OnDemandWebServer
{
    public class MyServer
    {
        private IDisposable _server;

        public void Start(string baseUrl)
        {
            _server = WebApp.Start<MyServerConfigurator>(url: baseUrl);
        }

        public void Stop()
        {
            _server.Dispose();
        }
    }
}