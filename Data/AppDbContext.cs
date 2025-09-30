using Microsoft.EntityFrameworkCore;
using Prevozi.WebApi.Models;

namespace Prevozi.WebApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Client> clients { get; set; }
    public DbSet<Carrier> carriers { get; set; }
    public DbSet<User> users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Client
        modelBuilder.Entity<Client>()
            .HasKey(c => c.registrationNumber);
        
        modelBuilder.Entity<User>()
            .HasOne(u => u.carrier)
            .WithMany()
            .HasForeignKey(u => u.carrierRegistrationNumber);


    }
    
}