namespace Api.Domain.Entities
{
    public class AccountEntity : BaseEntity
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double ValueBalance { get; set; }
        public string Status { get; set; }
    }
}
