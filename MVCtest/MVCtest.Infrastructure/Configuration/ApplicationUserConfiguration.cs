using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Infrastructure.Configuration
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();
            /*System.Guid guid = System.Guid.NewGuid();
            System.Guid guid2 = System.Guid.NewGuid();
            System.Guid guid3 = System.Guid.NewGuid();*/
            var user = new ApplicationUser()
            {
                Id =new Guid( "E43FA235-A6FE-400B-BCC1-3A1A6E793176" ),
                UserName = "admin@mail.com",
                FirstName = "Nikolas",
                LastName = "Emilov",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            user.PasswordHash =
                hasher.HashPassword(user, "admin123");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = new Guid("7BBD63AD-66F7-4F92-83AB-94E357C272D0"),
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            user.PasswordHash =
                hasher.HashPassword(user, "guest123");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id =new Guid("5B8F6F83-89BF-44E0-87D1-E8005D08F2F9"),
                UserName = "worker@mail.com",
                NormalizedUserName = "worker@mail.com",
                Email = "worker@mail.com",
                NormalizedEmail = "worker@mail.com",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            user.PasswordHash =
                hasher.HashPassword(user, "worker123");

            users.Add(user);

            return users;
        }
    }
}
