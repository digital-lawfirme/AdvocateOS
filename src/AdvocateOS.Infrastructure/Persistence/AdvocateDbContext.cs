using AdvocateOS.Domain.Cases;
using AdvocateOS.Domain.Evidences;
using Microsoft.EntityFrameworkCore;

namespace AdvocateOS.Infrastructure.Persistence;

public sealed class AdvocateDbContext : DbContext
{
    public AdvocateDbContext(DbContextOptions<AdvocateDbContext> options)
        : base(options)
    {
    }

    public DbSet<Case> Cases => Set<Case>();
    public DbSet<Evidence> Evidences => Set<Evidence>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdvocateDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
