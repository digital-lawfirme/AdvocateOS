// AdvocateOS.Infrastructure/Persistence/Configurations/EvidenceConfiguration.cs
using AdvocateOS.Domain.Cases;
using AdvocateOS.Domain.Evidences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvocateOS.Infrastructure.Persistence.Configurations;

public sealed class EvidenceConfiguration : IEntityTypeConfiguration<Evidence>
{
    public void Configure(EntityTypeBuilder<Evidence> builder)
    {
        builder.ToTable("Evidences");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.CaseId)
            .IsRequired();

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.FilePath)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(e => e.Description)
            .HasMaxLength(2000);

        builder.Property(e => e.CreatedAt)
            .IsRequired();

        builder.HasIndex(e => e.CaseId);

        builder.HasOne<Case>()
            .WithMany()
            .HasForeignKey(e => e.CaseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}