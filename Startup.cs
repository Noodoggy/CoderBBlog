using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoderBBlog.Startup))]
namespace CoderBBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
