using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(TicketingSystem.Web.Startup))]
namespace TicketingSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        
    }
}
