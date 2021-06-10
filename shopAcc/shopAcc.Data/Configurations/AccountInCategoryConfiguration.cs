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
    public class AccountInCategoryConfiguration : IEntityTypeConfiguration<AccountInCategory>
    {
        public void Configure(EntityTypeBuilder<AccountInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.AccountId });

            builder.ToTable("AccountInCategories");

            builder.HasOne(t => t.Account).WithMany(pc => pc.AccountInCategories)
                .HasForeignKey(pc => pc.AccountId);

            builder.HasOne(t => t.Category).WithMany(pc => pc.AccountInCategories)
              .HasForeignKey(pc => pc.CategoryId);
        }
    }
}