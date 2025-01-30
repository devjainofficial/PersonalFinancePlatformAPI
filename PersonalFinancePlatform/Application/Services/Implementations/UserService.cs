using PersonalFinancePlatformAPI.Application.Services.Interfaces;
using PersonalFinancePlatformAPI.Domain.IRepositories;
using PersonalFinancePlatformAPI.Entities;

namespace PersonalFinancePlatformAPI.Application.Services.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    public UserService()
    {

    }
    public Task<List<User>> GetUsers()
    {
        throw new NotImplementedException();
    }
}
