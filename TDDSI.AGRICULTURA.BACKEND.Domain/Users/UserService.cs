using TDDSI.AGRICULTURA.BACKEND.Domain.DomainService;
using TDDSI.AGRICULTURA.BACKEND.Domain.Ports;

namespace TDDSI.AGRICULTURA.BACKEND.Domain.Users;
[DomainService]
public class UserService(
    IUnitOfWork unitOfWork
) {

    public async Task<Guid> CreateUserAsync(
        User user,
        CancellationToken cancellationToken
    ) {
        ArgumentNullException.ThrowIfNull( nameof( user ) );

        await unitOfWork.Repository<User>()
            .AddAsync( user, cancellationToken );

        return user.Id;
    }
}
