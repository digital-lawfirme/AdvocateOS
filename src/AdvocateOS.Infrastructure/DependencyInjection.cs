// AdvocateOS.Infrastructure/DependencyInjection.cs
using AdvocateOS.Application.Abstractions.Persistence;
using AdvocateOS.Infrastructure.Persistence;
using AdvocateOS.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdvocateOS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AdvocateDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICaseRepository, CaseRepository>();
        services.AddScoped<IEvidenceRepository, EvidenceRepository>();

        return services;
    }
}