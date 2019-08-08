using Microsoft.Extensions.DependencyInjection;
using Sommelier.Models.Accounts;
using Sommelier.Models.Persons;
using Sommelier.Repositories;
using Sommelier.Repositories.Accounts;
using Sommelier.Repositories.Persons;
using Sommelier.Services.Accounts;
using Sommelier.Services.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sommelier.Api.Helpers
{
    public static class StartupHelpers
    {
        public static void InitializeRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmployeesService, EmployeesService>();
            serviceCollection.AddTransient<IConsultantsService, ConsultantsService>();
            serviceCollection.AddTransient<IAccountsService, AccountsService>();
        }

        public static void InitializeServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRepository<Employee>, EmployeesRepository>();
            serviceCollection.AddTransient<IRepository<Consultant>, ConsultantsRepository>();
            serviceCollection.AddTransient<IRepository<Account>, AccountsRepository>();
        }
    }
}
