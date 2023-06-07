using GoodHotel.DataAccess.DbContexts;
using GoodHotel.DataAccess.Interfaces.Users;
using GoodHotel.Domain.Entities.Users;

namespace GoodHotel.DataAccess.Repositories.Users;

public class UserRepository : GenericRepository<User>, IUserRepository 
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
