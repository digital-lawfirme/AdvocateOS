// AdvocateOS.Application/Abstractions/Persistence/ICaseRepository.cs
using AdvocateOS.Domain.Cases;

namespace AdvocateOS.Application.Abstractions.Persistence;

public interface ICaseRepository
{
    Task<Case?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Case @case, CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}