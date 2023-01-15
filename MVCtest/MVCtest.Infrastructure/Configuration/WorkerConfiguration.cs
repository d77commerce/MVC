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
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasData(CreateWorker());
        }



        public List<Worker> CreateWorker()
        {
            var workers = new List<Worker>()
            {
                new Worker()
                {
                    Id = 10,
                    UserId = new Guid("5B8F6F83-89BF-44E0-87D1-E8005D08F2F9"),
                    DepartmentId = 1
                }

            };
            return workers;
        }
    }
}