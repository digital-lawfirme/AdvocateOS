// src/AdvocateOS.Domain/Evidences/EvidenceId.cs
namespace AdvocateOS.Domain.Evidences;

public readonly record struct EvidenceId(Guid Value)
{
    public static EvidenceId New() => new(Guid.NewGuid());
}
