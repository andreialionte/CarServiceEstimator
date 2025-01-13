using CarServiceEstimator.Models;
using Microsoft.EntityFrameworkCore;

namespace CarServiceEstimator.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Deviz> Devize { get; set; }
        public DbSet<DevizContinut> ContinuturiDevize { get; set; }
        public DbSet<Reper> Repere { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("CarServiceEstimatorSchema");

            modelBuilder.Entity<Client>()
                .ToTable("Client")
                .HasKey(k => k.IdClient);

            modelBuilder.Entity<Client>()
                .HasMany(m => m.Devize)
                .WithOne(o => o.Client)
                .HasForeignKey(k => k.IdClient);

            modelBuilder.Entity<Deviz>()
                .ToTable("Deviz")
                .HasKey(k => k.IdDeviz);

            modelBuilder.Entity<Deviz>()
                .HasOne(c => c.Client)
                .WithMany(m => m.Devize)
                .HasForeignKey(k => k.IdClient);

            modelBuilder.Entity<DevizContinut>()
                .ToTable("DevizContinut")
                .HasKey(k => k.IdDevizContinut);

            modelBuilder.Entity<DevizContinut>()
                .HasOne(dc => dc.Deviz)
                .WithMany(d => d.DevizeContinut)
                .HasForeignKey(dc => dc.IdDeviz);

            modelBuilder.Entity<DevizContinut>()
                .HasOne(dc => dc.Reper)
                .WithMany(r => r.DevizeContinut)
                .HasForeignKey(dc => dc.IdReper);

            modelBuilder.Entity<Reper>()
                .ToTable("Reper")
                .HasKey(k => k.IdReper);

            modelBuilder.Entity<Reper>()
                .HasMany(r => r.DevizeContinut)
                .WithOne(dc => dc.Reper)
                .HasForeignKey(dc => dc.IdReper);
        }
    }
}
