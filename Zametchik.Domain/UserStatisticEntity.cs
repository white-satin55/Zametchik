namespace Zametchik.Domain;

public class UserStatisticEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public TimeSpan AccountAge { get; set; }
    public int CompletedToDoTasksCount { get; set; }
    public int ExpiredToDoTasksCount { get; set; }
    public UserEntity User { get; set; } = null!;    
}