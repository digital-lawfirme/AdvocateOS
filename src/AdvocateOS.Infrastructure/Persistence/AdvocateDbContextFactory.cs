// AdvocateOS.Infrastructure/Persistence/AdvocateDbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AdvocateOS.Infrastructure.Persistence;

public sealed class AdvocateDbContextFactory : IDesignTimeDbContextFactory<AdvocateDbContext>
{
    public AdvocateDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AdvocateOS.Presentation.WPF"))
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AdvocateDbContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        return new AdvocateDbContext(optionsBuilder.Options);
    }
}