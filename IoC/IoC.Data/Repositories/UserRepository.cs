using Microsoft.EntityFrameworkCore;
using IoC.Data.Contracts;
using IoC.Data.Entities;

namespace IoC.Data.Repositories
{
    public class UserRepository : BaseRepository<Company>, IUserRepository
    {
        public UserRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}