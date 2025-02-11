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
    internal class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(250);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Image).HasMaxLength(100);
            builder.Property(c => c.Link).HasMaxLength(100);
        }
    }
}
