using AdvocateOS.Application.Abstractions.Persistence;
using AdvocateOS.Domain.Evidences;
using MediatR;

namespace AdvocateOS.Application.Evidences.Create;

public sealed class CreateEvidenceCommandHandler
    : IRequestHandler<CreateEvidenceCommand, Guid>
{
    private readonly IEvidenceRepository _repository;

    public CreateEvidenceCommandHandler(IEvidenceRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(
        CreateEvidenceCommand request,
        CancellationToken cancellationToken)
    {
        var evidence = new Evidence(
            request.CaseId,
            request.Title,
            request.FilePath,
            request.Description);

        await _repository.AddAsync(evidence, cancellationToken);

        return evidence.Id;
    }
}
