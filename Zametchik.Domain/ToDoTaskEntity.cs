using Zametchik.Domain.Enums;

namespace Zametchik.Domain;

public class ToDoTaskEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime Deadline { get; set; }
    public TimeSpan AcceptableDelay { get; set; }
    public ToDoTaskStatus Status { get; set; }
    public ToDoTaskPriority Priority { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
    public ICollection<TagEntity> Tags { get; set; } = null!;
}