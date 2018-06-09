using System.Web.Http;
using DALF;
namespace WebAPIv2
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            System.Data.Entity.Database.SetInitializer(new NewCarDbInitialiser());
        }
    }
}
