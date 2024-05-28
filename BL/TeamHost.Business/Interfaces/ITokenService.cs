using TeamHost.DAL.Entities;

namespace TeamHost.Business.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(AppUser user, string role);
    }
}
