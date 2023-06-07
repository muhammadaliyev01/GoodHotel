using GoodHotel.DataAccess.DbContexts;
using GoodHotel.DataAccess.Interfaces;
using GoodHotel.DataAccess.Interfaces.News;
using GoodHotel.DataAccess.Interfaces.Users;
using GoodHotel.DataAccess.Repositories.News;
using GoodHotel.DataAccess.Repositories.Users;

namespace GoodHotel.DataAccess.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;
        
    public IRoomRepository Rooms { get;  }
    public IUserRepository Users { get; }

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.dbContext = appDbContext;

        Rooms = new RoomRepository(appDbContext);

        Users = new UserRepository(appDbContext);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}
