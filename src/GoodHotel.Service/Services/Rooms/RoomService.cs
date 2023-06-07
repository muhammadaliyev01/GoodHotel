using GoodHotel.DataAccess.Interfaces;
using GoodHotel.Domain.Entities.New;
using GoodHotel.Service.Common.Utils;
using GoodHotel.Service.Interfaces.Products;
using GoodHotel.Service.ViewModels.Products;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Errors.Model;

namespace GoodHotel.Service.Services.Products;
public class RoomService : IRoomService
{
    private readonly IUnitOfWork _repository;
    public RoomService(IUnitOfWork unitOfWork)
    {
        this._repository = unitOfWork;
    }
    public async Task<IEnumerable<RoomViewModel>> GetAllAsync(PaginationParams @params)
    {
        var query = _repository.Rooms.GetAll();
        var resalt= from news in query
               select new RoomViewModel()
               {
                   Id = news.Id,
                   Is_lux=news.is_lux,
                   price=news.price,
                   room_number=news.room_number,
                   place = news.place,
               };
        return resalt.ToList();
    }

    public async Task<RoomViewModel> GetAsync(long roomId)
    {
        var room = await _repository.Rooms.GetAll().FirstOrDefaultAsync(room=> room.Id== roomId);
        if (room is null) throw new NotFoundException("Ushbu id bilan maxsulot topilmadi!");

        return new RoomViewModel()
        {
            Id = room.Id,
            Is_lux = room.is_lux,
            price = room.price,
            room_number = room.room_number,
            place = room.place,
        };
    }

    //public async Task<bool> UpdateAsync(long id, RoomViewModel roomViewModel)
    //{
    //    roomViewModel.place = 1;
    //    var resalt = await _repository.Rooms.Update(id, roomViewModel);
    //    return resalt;
    //}
}
