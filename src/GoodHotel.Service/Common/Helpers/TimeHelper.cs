using GoodHotel.Domain.Constants;

namespace GoodHotel.Service.Common.Helpers;
public class TimeHelper
{
    public static DateTime GetCurrentServerTime()
    {
        var date = DateTime.UtcNow;
        return date.AddHours(TimeConstants.UTC);
    }
}
