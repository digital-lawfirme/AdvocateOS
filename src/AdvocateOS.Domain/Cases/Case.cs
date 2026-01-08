// AdvocateOS.Domain/Cases/Case.cs
namespace AdvocateOS.Domain.Cases;

public sealed class Case
{
    public Guid Id { get; private set; }

    public CaseType CaseType { get; private set; }

    public string Subject { get; private set; } = null!;
    public string? Claim { get; private set; }

    public string Court { get; private set; } = null!;
    public string? Branch { get; private set; }
    public string? Judge { get; private set; }

    private Case() { } // For EF

    public Case(
        CaseType caseType,
        string subject,
        string? claim,
        string court,
        string? branch,
        string? judge)
    {
        Id = Guid.NewGuid();
        CaseType = caseType;
        Subject = subject;
        Claim = claim;
        Court = court;
        Branch = branch;
        Judge = judge;
    }
}
