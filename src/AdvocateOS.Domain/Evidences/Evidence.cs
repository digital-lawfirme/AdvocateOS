namespace AdvocateOS.Domain.Evidences;

public sealed class Evidence
{
    public Guid Id { get; private set; }
    public Guid CaseId { get; private set; }

    public string Title { get; private set; } = null!;
    public string FilePath { get; private set; } = null!;
    public string? Description { get; private set; }

    public DateTime CreatedAt { get; private set; }

    private Evidence() { } // EF Core

    public Evidence(
        Guid caseId,
        string title,
        string filePath,
        string? description)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException(nameof(title));

        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentException(nameof(filePath));

        Id = Guid.NewGuid();
        CaseId = caseId;
        Title = title;
        FilePath = filePath;
        Description = description;
        CreatedAt = DateTime.UtcNow;
    }
}
