using GoodHotel.Service.Dtos.Accounts;
namespace GoodHotel.Service.Interfaces.Accounts;
public interface IAccountService
{
    public Task<bool> RegisterAsync(AccountRegisterDto accountRegisterDto);

    public Task<string> LoginAsync(AccountLoginDto accountLoginDto);
}
