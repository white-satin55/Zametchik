
using MediatR;
using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Commands.ToDoTasks.CreateToDoTaskCommand;
internal class CreateToDoTaskCommandHandler : IRequestHandler<CreateToDoTaskCommand, Guid>
{
    private readonly IAsyncRepository<ToDoTaskEntity> _toDoTaskEntityRepository;

    public CreateToDoTaskCommandHandler(IAsyncRepository<ToDoTaskEntity> toDoTaskEntityRepository)
    {
        _toDoTaskEntityRepository = toDoTaskEntityRepository;
    }

    public async Task<Guid> Handle(CreateToDoTaskCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateToDoTaskCommandValidator();
        var validationResult = validator.Validate(request);

        ToDoTaskEntity toDoTaskEntity = InitToDoTaskEntity(request);

        await _toDoTaskEntityRepository.Add(toDoTaskEntity);

        return Guid.Empty;
    }

    private ToDoTaskEntity InitToDoTaskEntity(CreateToDoTaskCommand command)
    {
        return new ToDoTaskEntity();
    }
}
