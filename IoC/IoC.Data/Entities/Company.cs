using System.Collections.Generic;
using IoC.Data.Contracts;
using IoC.Data.Contracts.Entities;

namespace IoC.Data.Entities
{
    public class Company : EntityBase
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}