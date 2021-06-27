using Mediator.Core;
using Mediator.Core.Contracts;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Mediator
{
    public static class ServiceCollectionExtensions
    {
        public static void AddArcMediator(this IServiceCollection services, System.Type type)
        {

            services.AddMediatR((Assembly.GetEntryAssembly()));
            services.AddTransient<IMediatorBus, MediatorBus>();


        }

    }


}
