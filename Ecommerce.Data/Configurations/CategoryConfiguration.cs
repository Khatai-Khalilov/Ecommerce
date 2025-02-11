using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Image).HasMaxLength(50);

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Computers",
                    IsActive = true,
                    IsTopMenu = true,
                    ParentId = 0,
                    OrderNo = 0,
                },

                new Category
                {
                    Id = 2,
                    Name = "Phones",
                    IsActive = true,
                    IsTopMenu = true,
                    ParentId = 0,
                    OrderNo = 1,
                }
            );
        }
    }
}
