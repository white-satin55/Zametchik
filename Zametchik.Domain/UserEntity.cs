namespace Zametchik.Domain;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<ToDoTaskEntity> ToDoTasks { get; set; } = null!;
    public ICollection<TagEntity> Tags { get; set; } = null!;
}