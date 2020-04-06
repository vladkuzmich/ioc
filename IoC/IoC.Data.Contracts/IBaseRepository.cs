using IoC.Data.Contracts.Entities;

namespace IoC.Data.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : EntityBase
    {
        // BASE CRUD API
    }
}