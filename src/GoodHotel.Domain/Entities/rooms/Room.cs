using GoodHotel.Domain.Common;
using GoodHotel.Domain.Entities.Users;

namespace GoodHotel.Domain.Entities.New
{
    public class Room : BaseEntity 
    {
        public int room_number { get; set; }

        public bool is_lux { get; set; }

        public double price { get; set; }

        public int place { get; set; }
    }
}
