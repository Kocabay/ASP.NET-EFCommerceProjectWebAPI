using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.FirstName)
              .HasColumnName("FirstName")
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(x => x.LastName)
              .HasColumnName("LastName")
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnName("Password")
                .HasMaxLength(20)
                 .IsRequired();

            builder.Property(x => x.Gender)
             .HasColumnName("Gender")
              .IsRequired();
            builder.Property(x => x.DateOfBirth)
               .HasColumnName("DateOfBirth")
              .IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.HasData(new User
            {
                Id = 1,
                FirstName = "Ali Veli",
                LastName = "konya",
                Password = "1324",
                Gender = true,
                DateOfBirth = Convert.ToDateTime("12-02-1998"),
                Address = "Sakarya",
                CreatedUserId = 1,
                UserName = "aliveli",
                Email = "aliveli@gmail.com"

            });

        }
    }
}
