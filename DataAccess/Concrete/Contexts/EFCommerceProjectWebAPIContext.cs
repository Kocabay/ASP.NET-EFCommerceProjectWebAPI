using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class EFCommerceProjectWebAPIContext : DbContext
    {
        public EFCommerceProjectWebAPIContext(DbContextOptions<EFCommerceProjectWebAPIContext> options) : base(options)
        {

        }
        public EFCommerceProjectWebAPIContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"Server=DESKTOP-39CPBHK\KOCABAY;Initial Catalog=EFCommerceProjectWebAPIDb;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
