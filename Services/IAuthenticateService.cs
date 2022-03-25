using AuthenticationApi.Models;

namespace AuthenticationApi.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
