using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(Chat.Startup))]

namespace Chat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // アプリケーションの設定方法の詳細については、http://go.microsoft.com/fwlink/?LinkID=316888 を参照してください
#if true
            app.MapSignalR();

#else 

            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJavaScriptProxies = false
            };


            app.MapSignalR("/signalr", hubConfiguration);
#endif

        
        }
    }
}
