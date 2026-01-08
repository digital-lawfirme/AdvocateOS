// AdvocateOS.Application/Cases/CreateCase/ICaseRepository.cs
using AdvocateOS.Domain.Cases;

namespace AdvocateOS.Application.Cases.CreateCase;

public interface ICaseRepository
{
    Task AddAsync(Case entity, CancellationToken ct);
}
