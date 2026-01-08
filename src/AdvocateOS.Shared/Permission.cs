// AdvocateOS.Shared/Security/Permission.cs
namespace AdvocateOS.Shared.Security;

public enum Permission
{
    CreateCase
}

public interface IPermissionService
{
    void Ensure(Guid userId, Permission permission);
}
