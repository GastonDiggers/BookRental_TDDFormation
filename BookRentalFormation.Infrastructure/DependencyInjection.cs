using BookRentalFormation.Application.Repositories;
using BookRentalFormation.Application.Services.RentService;
using BookRentalFormation.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BookRentalFormation.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IRentRepository, RentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
