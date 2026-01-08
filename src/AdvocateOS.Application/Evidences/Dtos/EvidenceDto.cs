namespace AdvocateOS.Application.Evidences.DTOs;

public sealed record EvidenceDto(
    Guid Id,
    string Title,
    string FilePath,
    string? Description,
    DateTime CreatedAt
);
