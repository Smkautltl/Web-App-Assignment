using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Swimming_Assignment.Startup))]
namespace Swimming_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
