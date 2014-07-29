using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day2GregsList.Startup))]
namespace Day2GregsList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
