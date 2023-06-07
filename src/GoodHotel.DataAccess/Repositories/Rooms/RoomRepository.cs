using GoodHotel.DataAccess.DbContexts;
using GoodHotel.DataAccess.Interfaces.News;
using GoodHotel.Domain.Entities.New;

namespace GoodHotel.DataAccess.Repositories.News;

public class RoomRepository : GenericRepository<Room>, IRoomRepository
{
    public RoomRepository(AppDbContext context) : base(context)
    {
    }
}
