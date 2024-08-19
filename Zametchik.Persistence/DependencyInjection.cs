using Microsoft.Extensions.DependencyInjection;

using Zametchik.Application.Repositories;
using Zametchik.Domain;
using Zametchik.Persistence.Repositories.AsyncRepositories;

namespace Zametchik.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {        
        services.AddScoped<IAsyncReadonlyRepository<ToDoTaskEntity>, ToDoTaskAsyncRepository>();
        services.AddScoped<IAsyncRepository<ToDoTaskEntity>, ToDoTaskAsyncRepository>();        
        services.AddScoped<IAsyncReadonlyRepository<UserEntity>, UserAsyncRepository>();
        services.AddScoped<IAsyncRepository<UserEntity>, UserAsyncRepository>();        

        return services;
    }
}
