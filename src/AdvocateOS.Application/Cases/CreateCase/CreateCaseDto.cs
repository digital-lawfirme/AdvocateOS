// AdvocateOS.Application/Cases/CreateCase/CreateCaseDto.cs
using AdvocateOS.Domain.Cases;

namespace AdvocateOS.Application.Cases.CreateCase;

public sealed class CreateCaseDto
{
    public CaseType CaseType { get; init; }

    public required string Subject { get; init; }

    public string? Claim { get; init; }

    public required string Court { get; init; }

    public string? Branch { get; init; }

    public string? Judge { get; init; }
}
