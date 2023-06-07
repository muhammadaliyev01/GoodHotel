using GoodHotel.Domain.Entities.Users;

namespace GoodHotel.Service.Interfaces.Common;
public interface IAuthService
{
    public string GenerateToken(User user);
}
