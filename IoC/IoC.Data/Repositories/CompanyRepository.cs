using IoC.Data.Contracts;
using IoC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace IoC.Data.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}