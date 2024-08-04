namespace Zametchik.Domain;

public class UserStatistic
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public TimeSpan AccountAge { get; set; }
    public int CompletedTasks { get; set; }
    public int ExpiredTasks { get; set; }
}