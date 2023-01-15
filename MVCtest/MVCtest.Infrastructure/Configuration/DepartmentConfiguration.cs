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
    internal class DepartmentConfiguration :IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(new Department()
            {
                Id=1,
                Name = "Administration",
                Address = "London",
                Managers = new List<Manager>(),
                Workers = new List<Worker>()
            });

        }
    }
}
