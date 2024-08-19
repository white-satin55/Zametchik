
using AutoMapper;

using MediatR;
using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Queries.ToDoTasks.GetToDoTaskQuery;
internal class GetToDoTaskQueryHandler : IRequestHandler<GetToDoTaskQuery, ToDoTaskVm>
{
    private readonly IAsyncReadonlyRepository<ToDoTaskEntity> _toDoTaskEntityRepository;

    public GetToDoTaskQueryHandler(IAsyncReadonlyRepository<ToDoTaskEntity> toDoTaskEntityRepository,
        IMapper mapper)
    {
        _toDoTaskEntityRepository = toDoTaskEntityRepository;
    }

    public async Task<ToDoTaskVm> Handle(GetToDoTaskQuery request, CancellationToken cancellationToken)
    {
        var toDoTaskEntity = await _toDoTaskEntityRepository.GetByIdAsync(request.Id);

        //TODO: сделать нормальный маппинг
        return new ToDoTaskVm()
        {
            Title = toDoTaskEntity.Title,
            Description = toDoTaskEntity.Description,
            Deadline = toDoTaskEntity.Deadline,
            AcceptableDelay = toDoTaskEntity.AcceptableDelay,
            Priority = (ToDoTaskVmPriority)toDoTaskEntity.Priority,
            Status = (ToDoTaskVmStatus)toDoTaskEntity.Status,
            Tags = toDoTaskEntity.Tags
                ?.Select(t => new ToDoTaskVmTag()
                {
                    Title = t.Title,
                })
                .ToArray()            
        };
    }    
}
