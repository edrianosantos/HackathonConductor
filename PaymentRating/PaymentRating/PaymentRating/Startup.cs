using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentRating.Startup))]
namespace PaymentRating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
