using AdvocateOS.Domain.Cases;
using AdvocateOS.Shared.Security;

namespace AdvocateOS.Application.Cases.CreateCase;

public sealed class CreateCaseCommandHandler
{
    private readonly ICaseRepository _repository;
    private readonly IPermissionService _permissionService;

    public CreateCaseCommandHandler(
        ICaseRepository repository,
        IPermissionService permissionService)
    {
        _repository = repository;
        _permissionService = permissionService;
    }

    public async Task<Guid> Handle(CreateCaseCommand command, CancellationToken ct)
    {
        _permissionService.Ensure(command.CurrentUserId, Permission.CreateCase);

        var v = CreateCaseValidator.Validate(command.Dto);

        var entity = new Case(
            v.CaseType,
            v.Subject,
            v.Claim,
            v.Court,
            v.Branch,
            v.Judge
        );

        await _repository.AddAsync(entity, ct);
        return entity.Id;
    }
}

