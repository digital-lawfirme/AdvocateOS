// AdvocateOS.Domain/Cases/CaseParty.cs
namespace AdvocateOS.Domain.Cases;

public sealed class CaseParty
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid CaseId { get; private set; }
    public Guid ClientId { get; private set; }
    public PartyRole Role { get; private set; }

    private CaseParty() { }

    public CaseParty(Guid caseId, Guid clientId, PartyRole role)
    {
        CaseId = caseId;
        ClientId = clientId;
        Role = role;
    }
}
