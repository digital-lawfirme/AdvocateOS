using FluentValidation;

namespace AdvocateOS.Application.Evidences.Create;

public sealed class CreateEvidenceValidator
    : AbstractValidator<CreateEvidenceCommand>
{
    public CreateEvidenceValidator()
    {
        RuleFor(x => x.CaseId)
            .NotEmpty();

        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.FilePath)
            .NotEmpty()
            .MaximumLength(500);

        RuleFor(x => x.Description)
            .MaximumLength(2000);
    }
}
