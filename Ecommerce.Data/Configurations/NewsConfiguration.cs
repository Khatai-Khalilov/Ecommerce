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
    internal class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(750);
            builder.Property(c => c.Image).IsRequired().HasMaxLength(100);
        }
    }
}
