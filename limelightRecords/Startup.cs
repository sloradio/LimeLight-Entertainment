using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(limelightRecords.Startup))]
namespace limelightRecords
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
