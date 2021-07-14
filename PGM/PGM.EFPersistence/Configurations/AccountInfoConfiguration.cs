using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PGM.Model;

namespace PGM.EFPersistence.Configurations
{
    /// <summary>
    /// NOTE: pay attemption on this item:
    /// the row size is important for this project, specially
    /// for Cloud system costs and performance. See more in Readme file.
    /// </summary>
    public class AccountInfoConfiguration
        : IEntityTypeConfiguration<AccountInfo>
    {
        public void Configure(EntityTypeBuilder<AccountInfo> builder)
        {
            builder
                .Property(account => account.Name)
                .HasColumnType("varchar(50)");

            builder
                .Property(account => account.Description)
                .HasColumnType("varchar(200)");

            builder
                .Property(account => account.ExpiresPass)
                .HasColumnType("bit");

            builder
                .Property(account => account.ExpiresPassDays)
                .HasColumnType("smallint");

            builder
                .Property(account => account.Password)
                .HasColumnType("varchar(256)");

        }
    }
}
