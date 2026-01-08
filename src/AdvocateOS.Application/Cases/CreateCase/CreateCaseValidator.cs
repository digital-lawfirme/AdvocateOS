// AdvocateOS.Application/Cases/CreateCase/CreateCaseValidator.cs
namespace AdvocateOS.Application.Cases.CreateCase;

public static class CreateCaseValidator
{
    public static CreateCaseDto Validate(CreateCaseDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Subject))
            throw new ArgumentException("موضوع پرونده الزامی است");

        if (string.IsNullOrWhiteSpace(dto.Court))
            throw new ArgumentException("دادگاه الزامی است");

        return dto;
    }
}

