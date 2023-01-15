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
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(CreateManager());

        }

        public List<Manager> CreateManager()
        {
            var manager = new List<Manager>()
            {
                new Manager()
                {
                    Id = 1,
                    UserId = new Guid("E43FA235-A6FE-400B-BCC1-3A1A6E793176"),
                    DepartmentId = 1,
                }
            };
            return manager;
        }
    }
}
