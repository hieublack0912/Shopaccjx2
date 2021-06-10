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
    public class AccountImageConfiguration : IEntityTypeConfiguration<AccountImage>
    {
        public void Configure(EntityTypeBuilder<AccountImage> builder)
        {
            builder.ToTable("AccountImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.Account).WithMany(x => x.AccountImages).HasForeignKey(x => x.AccountId);
        }
    }
}