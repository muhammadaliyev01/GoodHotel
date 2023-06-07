using GoodHotel.Service.Interfaces.Accounts;
using GoodHotel.Service.Interfaces.Common;
using GoodHotel.Service.Interfaces.Products;
using GoodHotel.Service.Services.Accounts;
using GoodHotel.Service.Services.Common;
using GoodHotel.Service.Services.Products;

namespace GoodHotel.Web.Configurations.LayerConfigurations;
public static class ServiceLayerConfiguration
{
    public static void AddService(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IRoomService, RoomService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IIdentityService, IdentityService>();
    }
}
