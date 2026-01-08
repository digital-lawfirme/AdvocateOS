// AdvocateOS.Infrastructure/Persistence/Configurations/CaseConfiguration.cs
using AdvocateOS.Domain.Cases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvocateOS.Infrastructure.Persistence.Configurations;

public sealed class CaseConfiguration : IEntityTypeConfiguration<Case>
{
    public void Configure(EntityTypeBuilder<Case> builder)
    {
        builder.ToTable("Cases");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever();

        builder.Property(c => c.CaseType)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(c => c.Subject)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(c => c.Claim)
            .HasMaxLength(2000);

        builder.Property(c => c.Court)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(c => c.Branch)
            .HasMaxLength(200);

        builder.Property(c => c.Judge)
            .HasMaxLength(200);

        builder.HasIndex(c => c.CaseType);
        builder.HasIndex(c => c.Court);
    }
}