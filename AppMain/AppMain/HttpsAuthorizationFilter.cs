using Hangfire.Dashboard;

namespace AppMain
{
    public class HttpsAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            // Allow access only if the request is over HTTPS
            if (context.GetHttpContext().Request.IsHttps)
            {
                return true;  // Authorized if HTTPS
            }

            // Redirect to HTTPS (if not already on HTTPS)
            context.GetHttpContext().Response.Redirect($"https://{context.GetHttpContext().Request.Host}{context.GetHttpContext().Request.Path}");
            return false;  // Unauthorized if not HTTPS
        }
    }
}
