using System.Collections.Generic;
using IoC.Data.Contracts;

namespace IoC.Data.Entities
{
    public class Company : EntityBase
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}