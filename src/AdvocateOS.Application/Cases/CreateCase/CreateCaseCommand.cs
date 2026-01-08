// AdvocateOS.Application/Cases/CreateCase/CreateCaseCommand.cs
namespace AdvocateOS.Application.Cases.CreateCase;

public sealed record CreateCaseCommand(
    CreateCaseDto Dto,
    Guid CurrentUserId
);
