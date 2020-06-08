using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongLamHuuLoc_BigSchool.Startup))]
namespace TruongLamHuuLoc_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
