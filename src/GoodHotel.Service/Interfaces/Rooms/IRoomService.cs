using GoodHotel.Domain.Entities.New;
using GoodHotel.Service.Common.Utils;
using GoodHotel.Service.ViewModels.Products;

namespace GoodHotel.Service.Interfaces.Products;
public interface IRoomService
{
    public Task<IEnumerable<RoomViewModel>> GetAllAsync(PaginationParams @params);

    public Task<RoomViewModel> GetAsync(long productId);

    //public Task<bool> UpdateAsync(long id,RoomViewModel roomViewModel);
}
