using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Infrastructure.Configuration
{
    public class CoverConfiguration : IEntityTypeConfiguration<Cover>
    {
        public void Configure(EntityTypeBuilder<Cover> builder)
        {
            builder.HasData(new Cover
            {
                Id = 1,
                Name = "One"
            });
        }
    }
}
