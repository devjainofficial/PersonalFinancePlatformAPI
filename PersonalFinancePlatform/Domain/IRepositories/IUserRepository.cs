using PersonalFinancePlatformAPI.Entities;

namespace PersonalFinancePlatformAPI.Domain.IRepositories;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}
