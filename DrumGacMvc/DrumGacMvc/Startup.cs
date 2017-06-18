using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrumGacMvc.Startup))]
namespace DrumGacMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
