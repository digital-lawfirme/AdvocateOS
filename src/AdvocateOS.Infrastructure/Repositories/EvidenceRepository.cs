// AdvocateOS.Infrastructure/Persistence/Repositories/EvidenceRepository.cs
using AdvocateOS.Application.Abstractions.Persistence;
using AdvocateOS.Domain.Evidences;
using Microsoft.EntityFrameworkCore;

namespace AdvocateOS.Infrastructure.Persistence.Repositories;

public sealed class EvidenceRepository : IEvidenceRepository
{
    private readonly AdvocateDbContext _context;

    public EvidenceRepository(AdvocateDbContext context)
    {
        _context = context;
    }

    public async Task<Evidence?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Evidences
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public async Task<IReadOnlyList<Evidence>> GetByCaseIdAsync(Guid caseId, CancellationToken cancellationToken = default)
    {
        return await _context.Evidences
            .Where(e => e.CaseId == caseId)
            .OrderByDescending(e => e.CreatedAt)
            .ToListAsync(cancellationToken);
    }

    public async Task AddAsync(Evidence evidence, CancellationToken cancellationToken = default)
    {
        await _context.Evidences.AddAsync(evidence, cancellationToken);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}