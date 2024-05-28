using System.Security.Claims;

namespace TeamHost.Business.Services
{
    public static class ClaimsExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            if (user.Claims == null)
                throw new ArgumentNullException(nameof(user.Claims));

            var claim = user.Identities.First().Claims.FirstOrDefault(c => c.Type == "Id");

            if (claim == null)
                throw new Exception("Token yoxdur");

            return claim.Value;
        }
    }
}
