using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace LAMS.Server.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly AuthenticationStateProvider _authProvider;

        public CurrentUserService(AuthenticationStateProvider authProvider)
        {
            _authProvider = authProvider;
        }

        /// <summary>
        /// Returns the user's ID (NameIdentifier claim) or null if not authenticated
        /// </summary>
        public async Task<string?> GetUserIdAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            return authState.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        /// <summary>
        /// Returns the user's email or null if not authenticated
        /// </summary>
        public async Task<string?> GetUserEmailAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            return authState.User?.FindFirst(ClaimTypes.Email)?.Value;
        }

        /// <summary>
        /// Returns true if the user is authenticated
        /// </summary>
        public async Task<bool> IsAuthenticatedAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            return authState.User?.Identity?.IsAuthenticated == true;
        }

        /// <summary>
        /// Returns a list of roles for the current user
        /// </summary>
        public async Task<IEnumerable<string>> GetUserRolesAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user?.Identity?.IsAuthenticated == true)
            {
                return user.FindAll(ClaimTypes.Role).Select(c => c.Value);
            }

            return Enumerable.Empty<string>();
        }

        /// <summary>
        /// Helper method to check if the user is in a specific role
        /// </summary>
        public async Task<bool> IsInRoleAsync(string role)
        {
            var roles = await GetUserRolesAsync();
            return roles.Contains(role);
        }
    }
}
