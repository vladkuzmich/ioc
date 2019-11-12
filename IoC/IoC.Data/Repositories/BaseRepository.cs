using System;
using IoC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace IoC.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : EntityBase
    {
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            DbSet = dbContext.Set<TEntity>();
        }
    }
}