using stock_fincance_api.Models;

namespace stock_fincance_api.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
