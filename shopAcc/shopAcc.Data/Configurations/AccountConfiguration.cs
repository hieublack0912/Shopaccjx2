using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopAcc.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Reincarnation).IsRequired();

            builder.Property(x => x.UserNameAcc).IsRequired().HasMaxLength(200);

            builder.Property(x => x.PasswordAcc).IsRequired().HasMaxLength(200);
        }
    }
}