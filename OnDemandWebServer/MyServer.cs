using System;
using System.Reflection;
using Microsoft.Owin.Hosting;

namespace OnDemandWebServer
{
    public class MyServer
    {
        private IDisposable _server;

        static MyServer()
        {
            Assembly.Load(typeof (Microsoft.Owin.Host.HttpListener.OwinHttpListener).Assembly.GetName());
        }

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