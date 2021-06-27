using Arc.Cqrs.Application.Contracts.Books;
using Arc.Cqrs.Application.Managers.Books;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arc.Cqrs.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBookManager, BookManager>();

        }
    }
}