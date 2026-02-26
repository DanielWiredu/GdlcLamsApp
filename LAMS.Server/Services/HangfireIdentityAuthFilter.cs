using Hangfire.Dashboard;

namespace LAMS.Server.Services
{
    public class HangfireIdentityAuthFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            var httpContext = context.GetHttpContext();
            return httpContext.User.Identity?.IsAuthenticated == true;
            //return httpContext.User.IsInRole("Admin");
        }
    }
}
