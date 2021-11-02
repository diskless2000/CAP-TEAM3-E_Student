using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAP_TEAM3_E_Student.Startup))]
namespace CAP_TEAM3_E_Student
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
