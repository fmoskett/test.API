using Microsoft.EntityFrameworkCore;
using Test.API.Domain.Models;

namespace Test.API.Persistence.Contexts {
    public class AppDbContext : DbContext {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Custumers> Custumer { get; set; }

        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);

            builder.Entity<Orders> ().ToTable ("Orders");
            builder.Entity<Orders> ().HasKey (p => p.Id);
            builder.Entity<Orders> ().Property (p => p.Id).IsRequired ().ValueGeneratedOnAdd ();
            builder.Entity<Orders> ().Property (p => p.productName).IsRequired ().HasMaxLength (30);
            builder.Entity<Orders>().Property(p => p.Amount).IsRequired();
            builder.Entity<Orders>().Property(p => p.Price).IsRequired();
            builder.Entity<Orders>().Property(p => p.Price).IsRequired();


            builder.Entity<Orders> ().HasMany 
                        (p => p.Custumer).WithOne (p => p.Order).HasForeignKey (p => p.Id);



            builder.Entity<Custumers> ().ToTable ("Custumers");
            builder.Entity<Custumers> ().HasKey (p => p.Id);
            builder.Entity<Custumers> ().Property (p => p.Id).IsRequired ().ValueGeneratedOnAdd ();
            builder.Entity<Custumers> ().Property (p => p.Name).IsRequired ().HasMaxLength (50);
            builder.Entity<Custumers> ().Property (p => p.Email).IsRequired ().HasMaxLength(50);
 
        }
    }
}