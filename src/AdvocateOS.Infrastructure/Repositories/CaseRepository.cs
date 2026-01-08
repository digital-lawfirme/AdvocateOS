// AdvocateOS.Infrastructure/Persistence/Repositories/CaseRepository.cs
using AdvocateOS.Application.Abstractions.Persistence;
using AdvocateOS.Domain.Cases;
using Microsoft.EntityFrameworkCore;

namespace AdvocateOS.Infrastructure.Persistence.Repositories;

public sealed class CaseRepository : ICaseRepository
{
    private readonly AdvocateDbContext _context;

    public CaseRepository(AdvocateDbContext context)
    {
        _context = context;
    }

    public async Task<Case?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Cases
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task AddAsync(Case @case, CancellationToken cancellationToken = default)
    {
        await _context.Cases.AddAsync(@case, cancellationToken);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}