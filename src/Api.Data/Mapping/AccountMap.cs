using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AccountMap : IEntityTypeConfiguration<AccountEntity>
    {
        public void Configure(EntityTypeBuilder<AccountEntity> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.AccountName)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.HasIndex(a => a.AccountNumber)
                   .IsUnique();

            builder.Property(a => a.ValueBalance);

            builder.Property(a => a.Status)
                    .HasMaxLength(50);

        }
    }
}
