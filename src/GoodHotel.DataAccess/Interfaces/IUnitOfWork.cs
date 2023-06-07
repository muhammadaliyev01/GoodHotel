using GoodHotel.DataAccess.Interfaces.News;
using GoodHotel.DataAccess.Interfaces.Users;

namespace GoodHotel.DataAccess.Interfaces;
public interface IUnitOfWork
{
    public IRoomRepository Rooms { get; }

    public IUserRepository Users { get; }

    public Task<int> SaveChangesAsync();
}
