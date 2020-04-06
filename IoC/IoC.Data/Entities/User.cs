using IoC.Data.Contracts;
using IoC.Data.Contracts.Entities;

namespace IoC.Data.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}