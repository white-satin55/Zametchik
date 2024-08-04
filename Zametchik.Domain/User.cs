namespace Zametchik.Domain;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Note> Notes { get; set; } = null!;
}