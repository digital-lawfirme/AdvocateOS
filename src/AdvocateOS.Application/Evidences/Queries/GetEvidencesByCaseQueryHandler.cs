using AdvocateOS.Application.Abstractions.Persistence;
using AdvocateOS.Application.Evidences.DTOs;
using MediatR;

namespace AdvocateOS.Application.Evidences.Queries;

public sealed class GetEvidencesByCaseQueryHandler
    : IRequestHandler<GetEvidencesByCaseQuery, IReadOnlyList<EvidenceDto>>
{
    private readonly IEvidenceRepository _repository;

    public GetEvidencesByCaseQueryHandler(IEvidenceRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyList<EvidenceDto>> Handle(
        GetEvidencesByCaseQuery request,
        CancellationToken cancellationToken)
    {
        var evidences = await _repository
            .GetByCaseIdAsync(request.CaseId, cancellationToken);

        return evidences
            .Select(e => new EvidenceDto(
                e.Id,
                e.Title,
                e.FilePath,
                e.Description,
                e.CreatedAt))
            .ToList();
    }
}
