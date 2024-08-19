
using MediatR;
using Zametchik.Application.Repositories;
using Zametchik.Domain;
using Zametchik.Domain.Enums;

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
        //var validationResult = validator.Validate(request);

        ToDoTaskEntity toDoTaskEntity = InitToDoTaskEntity(request);

        return await _toDoTaskEntityRepository.AddAsync(toDoTaskEntity);        
    }

    //TODO: сделать нормальный маппинг
    private ToDoTaskEntity InitToDoTaskEntity(CreateToDoTaskCommand command)
    {
        var toDoTaskEntity = new ToDoTaskEntity()
        {
            UserId = command.UserId,
            Title = command.Title,
            Description = command.Description,
            Deadline = command.Deadline,
            AcceptableDelay = command.AcceptableDelay,
            Priority = (ToDoTaskPriority)command.Priority,
            //Tags = new List<TagEntity>()
            CreationDate = DateTime.UtcNow,
            Status = ToDoTaskStatus.Active,           
        };

        return toDoTaskEntity;
    }
}
