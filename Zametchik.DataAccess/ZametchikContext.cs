using Microsoft.EntityFrameworkCore;
using Zametchik.Domain;

namespace Zametchik.DataAccess;

public class ZametchikContext(DbContextOptions<ZametchikContext> options) : DbContext(options)
{
    public DbSet<ToDoTaskEntity> ToDoTasks => Set<ToDoTaskEntity>();
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<TagEntity> Tags => Set<TagEntity>();
    public DbSet<UserStatisticEntity> UserStatistics => Set<UserStatisticEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}