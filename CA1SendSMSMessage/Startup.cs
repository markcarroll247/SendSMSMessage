using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA1SendSMSMessage.Startup))]
namespace CA1SendSMSMessage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
