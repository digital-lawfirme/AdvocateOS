// AdvocateOS.Application/Abstractions/Persistence/IEvidenceRepository.cs
using AdvocateOS.Domain.Evidences;

namespace AdvocateOS.Application.Abstractions.Persistence;

public interface IEvidenceRepository
{
    Task<Evidence?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Evidence>> GetByCaseIdAsync(Guid caseId, CancellationToken cancellationToken = default);
    Task AddAsync(Evidence evidence, CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}