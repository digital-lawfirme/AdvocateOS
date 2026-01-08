using MediatR;

namespace AdvocateOS.Application.Evidences.Create;

public sealed record CreateEvidenceCommand(
    Guid CaseId,
    string Title,
    string FilePath,
    string? Description
) : IRequest<Guid>;
