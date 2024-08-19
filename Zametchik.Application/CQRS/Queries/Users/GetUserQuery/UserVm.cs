namespace Zametchik.Application.CQRS.Queries.Users.GetUserQuery;

//TODO: убрать Id, поскольку вероятно это вызовет проблемы с безопасностью
internal class UserVm
{
    public Guid Id { get; set; }
    public string UserName { get; set; }

}


