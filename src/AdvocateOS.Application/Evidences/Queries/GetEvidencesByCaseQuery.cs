using MediatR;
using AdvocateOS.Application.Evidences.DTOs;

namespace AdvocateOS.Application.Evidences.Queries;

public sealed record GetEvidencesByCaseQuery(Guid CaseId)
    : IRequest<IReadOnlyList<EvidenceDto>>;
