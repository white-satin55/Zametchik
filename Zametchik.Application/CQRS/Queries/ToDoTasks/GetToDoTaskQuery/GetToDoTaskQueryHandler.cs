
using AutoMapper;

using MediatR;
using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Queries.ToDoTasks.GetToDoTaskQuery;
public class GetToDoTaskQueryHandler : IRequestHandler<GetToDoTaskQuery, ToDoTaskVm>
{
    private readonly IAsyncReadonlyRepository<ToDoTaskEntity> _toDoTaskEntityRepository;

    public GetToDoTaskQueryHandler(IAsyncReadonlyRepository<ToDoTaskEntity> toDoTaskEntityRepository,
        IMapper mapper)
    {
        _toDoTaskEntityRepository = toDoTaskEntityRepository;
    }

    public Task<ToDoTaskVm> Handle(GetToDoTaskQuery request, CancellationToken cancellationToken)
    {


        throw new NotImplementedException();
    }
}
