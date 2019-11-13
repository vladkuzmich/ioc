namespace IoC.Data.Contracts.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}