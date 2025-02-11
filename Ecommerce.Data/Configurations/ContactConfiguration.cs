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
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(c => c.Surname).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(c => c.Message).IsRequired().HasMaxLength(500);
        }
    }
}
