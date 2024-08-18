using System.Reflection;

using AutoMapper;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Commands.ToDoTasks.CreateToDoTaskCommand;
internal class CreateToDoTaskCommandMapper
{
    private IMapper _mapper;

    public CreateToDoTaskCommandMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public ToDoTaskEntity Map(CreateToDoTaskCommand command)
    {
        return new ToDoTaskEntity();
    }
}
