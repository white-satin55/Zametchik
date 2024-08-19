
using MediatR;

using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Commands.Users.CreateUserCommand;
internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IAsyncRepository<UserEntity> _userRepository;

    public CreateUserCommandHandler(IAsyncRepository<UserEntity> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateUserCommandValidator();
        var validationResult = validator.Validate(request);

        var user = new UserEntity()
        {
            UserName = request.UserName,
        };

        return await _userRepository.AddAsync(user);
    }
}
