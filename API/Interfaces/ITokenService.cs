using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        //single method signature

        string CreateToken(Appuser user);
    }
}