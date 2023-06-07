using GoodHotels.Service.Dtos.Common;

namespace GoodHotel.Service.Interfaces.Common;
public interface IEmailService
{
    public Task<bool> SendAsync(EmailMessage emailMessage);
}
