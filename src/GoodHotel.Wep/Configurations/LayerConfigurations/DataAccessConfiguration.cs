using GoodHotel.DataAccess.DbContexts;
using GoodHotel.DataAccess.Interfaces;
using GoodHotel.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GoodHotel.Web.Configurations.LayerConfigurations;
public static class DataAccessConfiguration
{
    public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DatabaseConnection")!;
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
