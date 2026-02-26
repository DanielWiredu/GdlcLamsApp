namespace LAMS.Server.Services
{
    public interface ICurrentUserService
    {
        Task<string?> GetUserIdAsync();
    }
}
