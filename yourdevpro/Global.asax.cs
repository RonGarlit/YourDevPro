using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DevProApp
{
    // Note: For instructions on enabling IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=301868
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // IMPORTANT ROUTING NOTE
            // MVC attribute routes registration
            // See: https://blogs.msdn.microsoft.com/webdev/2013/10/17/attribute-routing-in-asp-net-mvc-5/
            // Do BEFORE Registering all areas!!!
            RouteTable.Routes.MapMvcAttributeRoutes();

            // IMPORTANT ROUTING NOTE
            // Then you register all areas after above call to MapMvcAttributeRoutes()
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
