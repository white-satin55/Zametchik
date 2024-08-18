using FluentValidation;
using FluentValidation.Results;

namespace Zametchik.Application.CQRS.Commands.ToDoTasks.CreateToDoTaskCommand;
internal class CreateToDoTaskCommandValidator : AbstractValidator<CreateToDoTaskCommand>
{
    public override ValidationResult Validate(ValidationContext<CreateToDoTaskCommand> context)
    {
        return base.Validate(context);
    }
}
