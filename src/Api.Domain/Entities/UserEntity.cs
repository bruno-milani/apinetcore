using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBird { get; set; }
        public AccountEntity Account { get; set; }
    }
}
