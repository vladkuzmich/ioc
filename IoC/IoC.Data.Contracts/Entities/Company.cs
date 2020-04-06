using System.Collections.Generic;

namespace IoC.Data.Contracts.Entities
{
    public class Company : EntityBase
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}