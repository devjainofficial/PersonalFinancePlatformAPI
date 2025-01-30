using PersonalFinancePlatformAPI.Entities;

namespace PersonalFinancePlatformAPI.Application.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUsers();
}
