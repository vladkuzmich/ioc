using IoC.Data.Contracts.Entities;

namespace IoC.Data.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        // USER SPECIFIC API
    }
}